using Core.Helper.Toastr;
using Core.Helper.Toastr.OptionEnums;
using CoreDemo.Models;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.IO;
using System;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.Extensions.Localization;
using System.Linq;

namespace CoreDemo.Controllers
{
    [AllowAnonymous]
    public class UserController : Controller
    {
        private readonly SignInManager<User> _signInManager;
        private IMapper _mapper;
        private UserManager<User> _userManager;
        private IStringLocalizer<UserController> _localizer;

        public UserController(SignInManager<User> signInManager,IMapper mapper, UserManager<User> userManager, IStringLocalizer<UserController> localizer)
        {
            _mapper = mapper;
            _userManager = userManager;
            _localizer = localizer;
            _signInManager = signInManager;
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
                return View(viewModel);
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
            List<string> cities = new List<string>()
            {
                "", "Adana", "Adıyaman", "Afyon", "Ağrı", "Amasya", "Ankara", "Antalya", "Artvin",
                "Aydın", "Balıkesir", "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa", "Çanakkale",
                "Çankırı", "Çorum", "Denizli", "Diyarbakır", "Edirne", "Elazığ", "Erzincan", "Erzurum", "Eskişehir",
                "Gaziantep", "Giresun", "Gümüşhane", "Hakkari", "Hatay", "Isparta", "Mersin", "İstanbul", "İzmir",
                "Kars", "Kastamonu", "Kayseri", "Kırklareli", "Kırşehir", "Kocaeli", "Konya", "Kütahya", "Malatya",
                "Manisa", "Kahramanmaraş", "Mardin", "Muğla", "Muş", "Nevşehir", "Niğde", "Ordu", "Rize", "Sakarya",
                "Samsun", "Siirt", "Sinop", "Sivas", "Tekirdağ", "Tokat", "Trabzon", "Tunceli", "Şanlıurfa", "Uşak",
                "Van", "Yozgat", "Zonguldak", "Aksaray", "Bayburt", "Karaman", "Kırıkkale", "Batman", "Şırnak",
                "Bartın", "Ardahan", "Iğdır", "Yalova", "Karabük", "Kilis", "Osmaniye", "Düzce"
            };

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
            GetCities();

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(UserSignUpViewModel viewModel)
        {
            if (!ModelState.IsValid) return View(viewModel);

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

            return View(viewModel);
        }

        private string AssignFormFileAndReturnName(IFormFile file)
        {
            var extension = Path.GetExtension(file.FileName);

            var newName = Guid.NewGuid() + extension;
            var location = Path.Combine(Directory.GetCurrentDirectory() + @"\wwwroot\images", newName);
            var stream = new FileStream(location, FileMode.Create);
            file.CopyTo(stream);

            return newName;
        }
    }
}
