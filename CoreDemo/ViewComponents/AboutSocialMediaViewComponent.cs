using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents
{
    public class AboutSocialMediaViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
