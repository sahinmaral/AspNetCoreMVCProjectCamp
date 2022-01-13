using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents
{
    public class AdminNavbarViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}