using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Claims;
using System.Threading.Tasks;

using Business.Abstract;

using Core.Entities.Concrete;
using Core.Utilities.Security.Hashing;

using CoreDemo.Models;

using Entities.Concrete;

using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace CoreDemo.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly IUserService _userService;
        private readonly IAdminService _adminService;
        private readonly IWriterService _writerService;
        public LoginController(IUserService userService, IAdminService adminService, IWriterService writerService)
        {
            _userService = userService;
            _adminService = adminService;
            _writerService = writerService;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginUserViewModel viewModel)
        {
            User searchedUser = _userService.Get(x => x.Username == viewModel.Username);

            if (!ModelState.IsValid)
            {
                foreach (var keyValuePair in ModelState.Values.Where(x => x.ValidationState == ModelValidationState.Invalid))
                {
                    foreach (ModelError modelError in keyValuePair.Errors)
                    {
                        if (ViewData["LoginError"] != null)
                            ViewData["LoginError"] = ViewData["LoginError"] + modelError.ErrorMessage;
                        else
                            ViewData["LoginError"] = modelError.ErrorMessage;
                    }
                }

                return View(viewModel);
            }

            if (searchedUser == null)
            {
                ViewData["LoginError"] = "Böyle bir hesap bulunamadı";

                return View(viewModel);
            }

            if (HashingHelper.VerifyPasswordHash(viewModel.Password, searchedUser.UserPasswordHash,
                searchedUser.UserPasswordSalt))
            {
                ViewData["LoginError"] = "Kullanıcı adınızı veya şifrenizini kontrol ediniz";

                return View(viewModel);
            }

            await HttpContext.SignInAsync(AssignClaimsToUser(searchedUser));

            return RedirectToAction("GetAll", "Blog");
        }

        public ClaimsPrincipal AssignClaimsToUser(User searchedUser)
        {
            Writer searchedWriter = _writerService.Get(x => x.User.UserId == searchedUser.UserId);
            Admin searchedAdmin = _adminService.Get(x => x.User.UserId == searchedUser.UserId);

            ClaimsIdentity userIdentity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme);

            List<Claim> claims = new List<Claim> { new Claim(ClaimTypes.Name, searchedUser.Username) };

            if (searchedAdmin != null)
            {
                claims.Add(new Claim(ClaimTypes.Role, "Admin", CookieAuthenticationDefaults.AuthenticationScheme));
            }

            if (searchedWriter != null)
            {
                claims.Add(new Claim(ClaimTypes.Role, "Writer", CookieAuthenticationDefaults.AuthenticationScheme));
            }


            userIdentity.AddClaims(claims);
            var principal = new ClaimsPrincipal(userIdentity);
            

            return principal;
        }

        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            return RedirectToAction("GetAll", "Blog");
        }
    }
}
