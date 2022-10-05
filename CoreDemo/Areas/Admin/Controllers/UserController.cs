using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Business.Abstract;
using Core.Helper.Toastr;
using Core.Helper.Toastr.OptionEnums;
using CoreDemo.Areas.Admin.Models;
using CoreDemo.Models;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore;

namespace CoreDemo.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class UserController : Controller
    {
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<Role> _roleManager;

        public UserController(IMapper mapper, UserManager<User> userManager, RoleManager<Role> roleManager)
        {
            _mapper = mapper;
            _userManager = userManager;
            _roleManager = roleManager;
        }
        public IActionResult GetUsers()
        {
            return View();
        }

        public async Task<IActionResult> GetUsersJson()
        {
            ICollection<User> users = await _userManager.GetUsersInRoleAsync("User");

            List<ReadUserViewModel> userViewModels = _mapper.Map(users.Where(x=>x.UserName != User.Identity.Name), new List<ReadUserViewModel>());

            var jsonUsers = JsonConvert.SerializeObject(userViewModels);

            return Json(jsonUsers);
        }


        public IActionResult GetUsersByUsernameJson(string username)
        {
            List<User> users = _userManager.Users.Where(x => x.NormalizedUserName.Contains(username.ToUpper())).ToList();

            List<ReadUserViewModel> userViewModels = _mapper.Map(users.Where(x => x.UserName != User.Identity.Name), new List<ReadUserViewModel>());

            var jsonUsers = JsonConvert.SerializeObject(userViewModels);

            return Json(jsonUsers);

        }

        [HttpGet]
        public async Task<IActionResult> UpdateRolesToUser(int id)
        {
            User user = await _userManager.FindByIdAsync(id.ToString());
            List<Role> roles = _roleManager.Roles.ToList();

            List<RoleViewModel> roleViewModels = new List<RoleViewModel>();

            foreach (Role role in roles)
            {
                bool isInRole = await _userManager.IsInRoleAsync(user, role.Name);
                roleViewModels.Add(new RoleViewModel()
                {
                    IsInRole = isInRole,
                    RoleName = role.Name
                });
            }

            UserRoleViewModel viewModel = new UserRoleViewModel()
            {
                RoleViewModels = roleViewModels,
                UserViewModel = _mapper.Map(user, new ReadUserViewModel())
            };


            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateRolesToUser(UserRoleViewModel viewModel)
        {
            User user = await _userManager.FindByIdAsync(viewModel.UserViewModel.UserId.ToString());

            foreach (RoleViewModel roleViewModel in viewModel.RoleViewModels)
            {
                bool isInRoleSaved = await _userManager.IsInRoleAsync(user, roleViewModel.RoleName);

                if (!isInRoleSaved && roleViewModel.IsInRole)
                    await _userManager.AddToRoleAsync(user, roleViewModel.RoleName);

                else if (isInRoleSaved && !roleViewModel.IsInRole)
                    await _userManager.RemoveFromRoleAsync(user, roleViewModel.RoleName);
            }

            TempData["Message"] = ToastrNotification.Show("Sectiginiz kullanicinin rolleri duzenlenmistir.", position: Position.BottomRight,
                type: ToastType.success);

            return RedirectToAction("GetUsers");
        }

        //public async Task EnableOrDisableUser(int id)
        //{
        //    AppUser user = await _userManager.FindByIdAsync(id.ToString());

        //    user.LockoutEnabled = !user.LockoutEnabled;

        //    await _userManager.UpdateAsync(user);
        //}
    }
}
