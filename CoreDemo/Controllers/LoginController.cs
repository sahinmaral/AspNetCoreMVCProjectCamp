using Business.Abstract;
using CoreDemo.Models;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
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
        public IActionResult LoginWriter(LoginWriterViewModel viewModel)
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


            return RedirectToAction("GetAll","Blog");
        }
    }
}
