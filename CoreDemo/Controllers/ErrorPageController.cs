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
            ErrorMessageViewModel viewModel = new ErrorMessageViewModel
            {
                StatusCode = code
            };

            switch (code)
            {
                case 404:
                    viewModel.Message = "Oops! Sayfa Bulunamadı!";
                    break;
                case 403:
                    viewModel.Message = "Oops! Bu sayfaya gitmeniz için yetkiniz yok.";
                    break;
                case 401:
                    viewModel.Message = "Oops! Giriş Yapmanız Gerekiyor!";
                    break;
            }


            return View(viewModel);
        }




    }
}
