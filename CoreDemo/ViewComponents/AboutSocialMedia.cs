using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents
{
    public class AboutSocialMedia:ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            return View();
        }
    }
}
