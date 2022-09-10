using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Claims;
using System.Threading.Tasks;

using AutoMapper;

using Business.Abstract;
using Core.Helper.Toastr;
using Core.Helper.Toastr.OptionEnums;
using CoreDemo.Models;
using DocumentFormat.OpenXml.Drawing;
using Entities.Concrete;

using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Position = Core.Helper.Toastr.OptionEnums.Position;

namespace CoreDemo.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;
        public LoginController(SignInManager<AppUser> signInManager)
        {
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
                    TempData["Message"] = ToastrNotification.Show("Logined successfully", position: Position.BottomRight,
                        type: ToastType.success);

                    return RedirectToAction("GetAll", "Blog");  
                }

                return View(viewModel);
            }
                
            
            return View(viewModel);
        }


        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction("GetAll", "Blog");
        }
    }
}
