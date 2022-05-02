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

namespace CoreDemo.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class UserController : Controller
    {
        private readonly IMapper _mapper;
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<AppRole> _roleManager;

        public UserController(IMapper mapper, UserManager<AppUser> userManager, RoleManager<AppRole> roleManager)
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
            IList<AppUser> users = await _userManager.GetUsersInRoleAsync("User");

            List<ReadUserViewModel> userViewModels = _mapper.Map(users, new List<ReadUserViewModel>());

            var jsonUsers = JsonConvert.SerializeObject(userViewModels);

            return Json(jsonUsers);
        }


        public async Task<IActionResult> GetUserByIdJson(int id)
        {
            AppUser user = await _userManager.FindByIdAsync(id.ToString());
            ReadUserViewModel viewModel = _mapper.Map(user, new ReadUserViewModel());

            var jsonUsers = JsonConvert.SerializeObject(viewModel);

            return Json(jsonUsers);

        }

        [HttpGet]
        public async Task<IActionResult> UpdateRolesToUser(int id)
        {
            AppUser user = await _userManager.FindByIdAsync(id.ToString());
            List<AppRole> roles = _roleManager.Roles.ToList();

            List<RoleViewModel> roleViewModels = new List<RoleViewModel>();

            foreach (AppRole role in roles)
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
            AppUser user = await _userManager.FindByIdAsync(viewModel.UserViewModel.UserId.ToString());

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
