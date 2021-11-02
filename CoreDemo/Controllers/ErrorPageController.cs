using CoreDemo.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    [AllowAnonymous]
    public class ErrorPageController : Controller
    {
        
        [Route("/ErrorPage/ErrorPage/{code}")]
        public IActionResult ErrorPage(int code)
        {
            ErrorMessageViewModel viewModel = new ErrorMessageViewModel();

            switch (code)
            {
                case 404:
                    viewModel.StatusCode = code;
                    viewModel.ErrorMessage = "Oops! Sayfa Bulunamadı!";
                    break;
                case 401:
                    viewModel.StatusCode = code;
                    viewModel.ErrorMessage = "Oops! Giriş Yapmanız Gerekiyor!";
                    break;
            }

            return View(viewModel);
        }
    }
}
