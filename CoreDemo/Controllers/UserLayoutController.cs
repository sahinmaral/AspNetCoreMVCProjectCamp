using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class UserLayoutController : Controller
    {
        public PartialViewResult FooterPartialView()
        {
            return PartialView();
        }

        public PartialViewResult NavbarPartialView()
        {
            return PartialView();
        }
    }
}