using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Threading;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    [AllowAnonymous]
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

        public IActionResult SetLanguage(string culture, string returnUrl)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
            );
            ViewData["culture"] = culture;

            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo(culture);
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(culture);

            return LocalRedirect(returnUrl); 
        }

    }
}