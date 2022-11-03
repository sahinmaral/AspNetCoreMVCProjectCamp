using AutoMapper;
using Business.Abstract;
using CoreDemo.Models;
using Entities.Concrete;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

using System.Collections.Generic;

using System.Globalization;

using System.IO;

using System.Threading.Tasks;

using System;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Core.Helper.Toastr.OptionEnums;
using Core.Helper.Toastr;
using Microsoft.Extensions.Localization;

namespace CoreDemo.Areas.Writer.Controllers
{
    [Authorize(Roles = "Writer")]
    [Area("Writer")]
    public class HomeController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IBlogService _blogService;
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;
        private readonly IStringLocalizer<HomeController> _localizer;
        public HomeController(IBlogService blogService, IMapper mapper, ICategoryService categoryService, UserManager<User> userManager, IStringLocalizer<HomeController> localizer)
        {
            _blogService = blogService;
            _mapper = mapper;
            _categoryService = categoryService;
            _userManager = userManager;
            _localizer = localizer;
        }

        public PartialViewResult WriterSidebar()
        {
            return PartialView();
        }

        public async Task<IActionResult> Homepage()
        {
            User user = await _userManager.FindByNameAsync(User.Identity.Name);

            return View(_mapper.Map(user, new ReadUserViewModel()));
        }

        [HttpGet]
        public async Task<IActionResult> ChangeProfileInformations()
        {
            User user = await _userManager.FindByNameAsync(User.Identity.Name);

            ReadUserViewModel viewModel = _mapper.Map(user, new ReadUserViewModel());

            return View(viewModel);
        }


        [HttpPost]
        public async Task<IActionResult> ChangeProfileInformations(ReadUserViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }

            User user = await _userManager.FindByNameAsync(User.Identity.Name);
            user.About = viewModel.About;
            user.NameSurname = viewModel.NameSurname;

            await _userManager.UpdateAsync(user);
            TempData["Message"] = ToastrNotification.Show(_localizer["ProfileInformationsSuccessfullyChanged"], position: Position.BottomRight,
                type: ToastType.success);

            return Redirect($"/{nameof(Writer)}/{nameof(HomeController).Replace("Controller","")}/{nameof(HomeController.Homepage)}");
        }

        [HttpGet]
        public IActionResult ChangePassword()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ChangePassword(UserPasswordViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }

            User user = await _userManager.FindByNameAsync(User.Identity.Name);

            PasswordVerificationResult result = _userManager.PasswordHasher.VerifyHashedPassword(user, user.PasswordHash, viewModel.NewPassword);
            if(result == PasswordVerificationResult.Success) {
                TempData["Message"] = ToastrNotification.Show(_localizer["OldAndNewPasswordsCannotBeSame"], position: Position.BottomRight,
                    type: ToastType.error);

                return View(viewModel);
            }
            else
            {
                user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, viewModel.NewPassword);
                await _userManager.UpdateAsync(user);
                TempData["Message"] = ToastrNotification.Show(_localizer["PasswordSuccessfullyChanged"], position: Position.BottomRight,
                    type: ToastType.success);
                return Redirect($"/{nameof(Writer)}/{nameof(HomeController).Replace("Controller", "")}/{nameof(HomeController.Homepage)}");
            }

            
        }

        [HttpGet]
        public IActionResult ChangeProfilePhoto()
        {
            return View(new UserImageViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> ChangeProfilePhoto(UserImageViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }

            User user = await _userManager.FindByNameAsync(User.Identity.Name);

            if (user.ImageUrl != null)
                RemoveOldProfilePicture(user.ImageUrl);

            user.ImageUrl = AssignFormFileAndReturnName(viewModel.ProfileImage);

            await _userManager.UpdateAsync(user);
            TempData["Message"] = ToastrNotification.Show(_localizer["ProfileImageSuccessfullyChanged"], position: Position.BottomRight,
                    type: ToastType.success);

            return Redirect($"/{nameof(Writer)}/{nameof(HomeController).Replace("Controller", "")}/{nameof(HomeController.Homepage)}");
        }

        private void RemoveOldProfilePicture(string path)
        {
            System.IO.File.Delete(Directory.GetCurrentDirectory() + @"\wwwroot\images" + path);
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

       
    }
}
