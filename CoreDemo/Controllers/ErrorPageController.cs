using CoreDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult ErrorPage(int code)
        {
            ErrorMessageViewModel viewModel = new ErrorMessageViewModel();

            switch (code)
            {
                case 404:
                    viewModel.StatusCode = code;
                    viewModel.ErrorMessage = "Oops! Sayfa Bulunamadı!";
                    break;
            }

            return View(viewModel);
        }
    }
}
