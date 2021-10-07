using CoreDemo.Models;

using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents
{
    public class SubscribeEmailAtAbout:ViewComponent
    {
        
        public IViewComponentResult Invoke()
        {
            return View(new CreateNewsLetterViewModel());
        }
    }
}