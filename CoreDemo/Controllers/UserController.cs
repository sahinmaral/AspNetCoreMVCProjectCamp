using AutoMapper;
using Business.Abstract;
using Core.Helper.Toastr;
using Core.Helper.Toastr.OptionEnums;
using CoreDemo.Models;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Localization;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    [AllowAnonymous]
    public class UserController : Controller
    {
        private readonly SignInManager<User> _signInManager;
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;
        private readonly IBlogService _blogService;
        private readonly IStringLocalizer<UserController> _localizer;
        private readonly ICategoryService _categoryService;
        private readonly ICommentService _commentService;
        private List<string> cities;

        public UserController(SignInManager<User> signInManager, IMapper mapper, UserManager<User> userManager, IStringLocalizer<UserController> localizer, IBlogService blogService, ICategoryService categoryService, ICommentService commentService)
        {
            _mapper = mapper;
            _userManager = userManager;
            _localizer = localizer;
            _signInManager = signInManager;
            _blogService = blogService;
            _categoryService = categoryService;
            _commentService = commentService;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(UserSignInViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(viewModel.Username, viewModel.Password, false, true);
                if (result.Succeeded)
                {
                    TempData["Message"] = ToastrNotification.Show(_localizer["LoginedSuccessfully"], position: Position.BottomRight,
                        type: ToastType.success);

                    return RedirectToAction(nameof(BlogController.GetAll), nameof(BlogController).Replace("Controller", ""));
                }
                else if (result.IsLockedOut)
                {
                    User user = await _userManager.FindByNameAsync(viewModel.Username);

                    TempData["Message"] = ToastrNotification.Show(_localizer["Banned",user.LockoutEnd], position: Position.BottomRight,
                        type: ToastType.error);
                    return View(viewModel);
                }
                else
                {
                    TempData["Message"] = ToastrNotification.Show(_localizer["PasswordOrUsernameIncorrect"], position: Position.BottomRight,
                        type: ToastType.error);
                    return View(viewModel);
                }  
            }


            return View(viewModel);
        }


        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction(nameof(BlogController.GetAll), nameof(BlogController).Replace("Controller", ""));
        }

        public void GetCities()
        {

            using (StreamReader r = new StreamReader(Directory.GetCurrentDirectory() + "/Constants/cities.json"))
            {
                string json = r.ReadToEnd();
                cities = JsonConvert.DeserializeObject<List<string>>(json); 
            }

            cities.Sort();

            List<SelectListItem> citieSelectListItems = (from x in cities
                                                         select new SelectListItem()
                                                         {
                                                             Text = x,
                                                             Value = x
                                                         }).ToList();

            ViewBag.Cities = citieSelectListItems;
        }

        [HttpGet]
        public IActionResult Register()
        {
            //GetCities();

            return View();
        }

        [HttpPost]
        [RequestSizeLimit(10000000)] 
        public async Task<IActionResult> Register(UserSignUpViewModel viewModel)
        {

            if (ModelState.IsValid)
            {
                User newUser = _mapper.Map<User>(viewModel);

                newUser.ImageUrl = AssignFormFileAndReturnName(viewModel.ProfileImage);

                var result = await _userManager.CreateAsync(newUser, viewModel.Password);

                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(newUser, "User");

                    TempData["Message"] = ToastrNotification.Show(_localizer["RegisteredSuccessfully"], position: Position.BottomRight,
                        type: ToastType.success);

                    return RedirectToAction(nameof(Login), nameof(UserController).Replace("Controller", ""));
                }
            }

            return View(viewModel);

        }

        private string AssignFormFileAndReturnName(IFormFile file)
        {
            var extension = Path.GetExtension(file.FileName);

            var newName = Guid.NewGuid() + extension;
            var location = Path.Combine(Directory.GetCurrentDirectory() + @"\wwwroot\images", newName);
            var stream = new FileStream(location, FileMode.Create);
            file.CopyTo(stream);
            stream.Close();

            return newName;
        }

        [Route("/User/SeeProfile/{username}")]
        public async Task<IActionResult> SeeProfile(string username)
        {
            User user = await _userManager.FindByNameAsync(username);
            var roles = await _userManager.GetRolesAsync(user);

            ReadUserViewModel userViewModel = _mapper.Map(user, new ReadUserViewModel());
            if (roles.Count > 1) userViewModel.MainRole = roles.First(x => x != "User");
            else userViewModel.MainRole = "User";

            List<Blog> blogs = _blogService.GetAll();
            List<Category> categories = _categoryService.GetAll();
            List<Comment> comments = _commentService.GetAll();

            string favouriteCategoryName = _localizer["None"];


            if(blogs.Count != 0 && blogs.Count(x=>x.UserId == user.Id) > 0)
            {
                var filteredCategoryEntity = blogs.Where(x => x.UserId == user.Id)
                .GroupBy(x => x.CategoryId)
                .Select(x => new
                {
                    CategoryId = x.Key,
                    Count = x.Count()
                })
                .OrderByDescending(x => x.Count).First();

                favouriteCategoryName = categories.Find(x => x.Id == filteredCategoryEntity.CategoryId).Name;
            }
        

            var blogWrittenCount = blogs.Count(x => x.UserId == user.Id);


            UserProfileViewModel viewModel = new UserProfileViewModel
            {
                UserViewModel = userViewModel,
                FavouriteCategoryName = favouriteCategoryName,
                BlogWrittenCount = blogWrittenCount,
                CommentWrittenCount = comments.Count(x => x.UserId == user.Id),
                LikedBlogCount = comments.Count(x => x.UserId == user.Id && x.LikeOrDislikeStatus == true),
                DislikedBlogCount = comments.Count(x => x.UserId == user.Id && x.LikeOrDislikeStatus == false),
            };
    

            return View(viewModel);
        }
    }
}


