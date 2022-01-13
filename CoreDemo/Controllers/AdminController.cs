using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Homepage()
        {
            //string loggedWriterUsername = HttpContext.User.Claims.Single().Subject.Name;
            //Writer writer = _writerService.Get(x => x.WriterUsername == loggedWriterUsername);

            return View();
        }
    }
}
