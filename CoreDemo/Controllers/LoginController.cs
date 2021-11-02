using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Business.Abstract;
using CoreDemo.Models;
using Entities.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly IWriterService _writerService;
        public LoginController(IWriterService writerService)
        {
            _writerService = writerService;
        }

        [HttpGet]
        public IActionResult LoginWriter()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> LoginWriter(LoginWriterViewModel viewModel)
        {
            Writer searchedWriter = _writerService.Get(x => x.WriterUsername == viewModel.WriterUsername);

            if (searchedWriter == null)
            {
                ViewData["LoginError"] = "Böyle bir hesap bulunamadı";

                return View(viewModel);
            }

            if (searchedWriter.WriterPassword != viewModel.WriterPassword)
            {
                ViewData["LoginError"] = "Kullanıcı adınızı veya şifrenizini kontrol ediniz";

                return View(viewModel);
            }


            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, searchedWriter.WriterUsername)
            };

            var userIdentity = new ClaimsIdentity(claims,"writer");

            ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);

            await HttpContext.SignInAsync(principal);
            
            return RedirectToAction("GetAll","Blog");
        }
    }
}
