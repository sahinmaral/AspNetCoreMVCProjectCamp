using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Areas.Admin.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
