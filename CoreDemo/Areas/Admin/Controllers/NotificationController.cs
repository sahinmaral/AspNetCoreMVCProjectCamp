using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Areas.Admin.Controllers
{
    public class NotificationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
