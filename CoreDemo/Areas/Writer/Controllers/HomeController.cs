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

        public HomeController(IBlogService blogService, IMapper mapper, ICategoryService categoryService, UserManager<User> userManager)
        {
            _blogService = blogService;
            _mapper = mapper;
            _categoryService = categoryService;
            _userManager = userManager;
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
        public async Task<IActionResult> ChangeProfile()
        {
            User user = await _userManager.FindByNameAsync(User.Identity.Name);

            ReadUserViewModel viewModel = _mapper.Map(user, new ReadUserViewModel());

            return View(viewModel);
        }


        [HttpPost]
        public async Task<IActionResult> ChangeProfile(ReadUserViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }

            User user = await _userManager.FindByNameAsync(User.Identity.Name);
            user.UserAbout = viewModel.UserAbout;

            await _userManager.UpdateAsync(user);

            return RedirectToAction(nameof(Homepage), nameof(BlogController).Replace("Controller", ""));
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
            user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, viewModel.NewPassword);

            await _userManager.UpdateAsync(user);

            return RedirectToAction(nameof(Homepage), nameof(HomeController).Replace("Controller", ""));
        }

        [HttpGet]
        public IActionResult ChangeProfilePhoto()
        {
            return View(new UserPictureViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> ChangeProfileImage(UserPictureViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }

            User user = await _userManager.FindByNameAsync(User.Identity.Name);

            if (user.ImageUrl != null)
                RemoveOldProfilePicture(user.ImageUrl);

            user.ImageUrl = AssignFormFileAndReturnName(viewModel.ProfilePhoto);

            await _userManager.UpdateAsync(user);

            return RedirectToAction(nameof(Homepage), nameof(HomeController).Replace("Controller", ""));
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
