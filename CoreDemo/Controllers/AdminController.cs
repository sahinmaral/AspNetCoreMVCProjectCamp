using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Microsoft.AspNetCore.Authorization;
using Entities.Concrete;

namespace CoreDemo.Controllers
{
    [Authorize(Roles = "Admin,Writer")]
    public class AdminController : Controller
    {
        private readonly IAdminService _adminService;

        public AdminController(IAdminService adminService)
        {
            _adminService = adminService;
        }
        public IActionResult Homepage()
        {
            string loggedAdminUsername = HttpContext.User.Claims.ToArray()[0].Subject.Name;
            Admin admin = _adminService.Get(x => x.User.Username == loggedAdminUsername);


            return View();
        }
    }
}
