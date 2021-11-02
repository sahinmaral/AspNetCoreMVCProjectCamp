using CoreDemo.Models;

using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents
{
    public class SubscribeEmailAtBlogViewComponent:ViewComponent
    {
        
        public IViewComponentResult Invoke()
        {
            return View(new CreateNewsLetterViewModel());
        }
    }
}