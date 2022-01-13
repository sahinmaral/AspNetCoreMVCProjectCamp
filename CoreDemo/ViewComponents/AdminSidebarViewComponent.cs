using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents
{
    public class AdminSidebarViewComponent : ViewComponent
    {
        
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}