using AutoMapper;
using Business.Abstract;
using Core.Helper.Toastr;
using Core.Helper.Toastr.OptionEnums;
using CoreDemo.Areas.Admin.Models;
using CoreDemo.Models;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Localization;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class UserController : Controller
    {
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<Role> _roleManager;
        private readonly IStringLocalizer<UserController> _localizer;

        public UserController(IMapper mapper, UserManager<User> userManager, RoleManager<Role> roleManager, IStringLocalizer<UserController> localizer)
        {
            _mapper = mapper;
            _userManager = userManager;
            _roleManager = roleManager;
            _localizer = localizer;
        }
        public IActionResult GetUsers()
        {
            return View();
        }

        public async Task<IActionResult> GetUsersJson()
        {
            ICollection<User> users = await _userManager.GetUsersInRoleAsync("User");

            List<ReadUserViewModel> userViewModels = _mapper.Map(users.Where(x => x.UserName != User.Identity.Name), new List<ReadUserViewModel>());

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
            List<Role> roles = _roleManager.Roles.ToList().Where(x => x.Name != "User").ToList();
            RoleViewModel userRole = new RoleViewModel();

            foreach (Role role in roles)
            {
                bool isInRole = await _userManager.IsInRoleAsync(user, role.Name);
                if (isInRole)
                {
                    userRole = new RoleViewModel();
                    userRole.RoleName = role.Name;
                    userRole.IsInRole = true;
                }
            }

            ViewData["Roles"] = (from x in roles
                                 select new SelectListItem()
                                 {
                                     Text = x.Name,
                                     Value = x.Name.ToString()
                                 }).ToList();

            UserRoleViewModel viewModel = new UserRoleViewModel()
            {
                RoleViewModel = userRole,
                UserViewModel = _mapper.Map(user, new ReadUserViewModel())
            };


            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateRolesToUser(UserRoleViewModel viewModel)
        {
            User user = await _userManager.FindByNameAsync(viewModel.UserViewModel.Username);

            var roles = _roleManager.Roles.ToList().Where(x => x.Name != "User").ToList();

            foreach (Role role in roles)
            {
                await _userManager.RemoveFromRoleAsync(user, role.Name);
            }


            await _userManager.AddToRoleAsync(user, viewModel.RoleViewModel.RoleName);


            TempData["Message"] = ToastrNotification.Show(_localizer["RolesSuccessfullyUpdated"], position: Position.BottomRight,
                type: ToastType.success);

            return RedirectToAction(nameof(GetUsers));
        }

        [HttpGet]
        public async Task<IActionResult> BanUser(int id)
        {
            User user = await _userManager.FindByIdAsync(id.ToString());

            UserLockoutViewModel viewModel = _mapper.Map(user, new UserLockoutViewModel());

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> BanUser(UserLockoutViewModel viewModel)
        {
            User user = await _userManager.FindByNameAsync(viewModel.UserViewModel.Username);

            user.LockoutEnd = viewModel.LockoutEnd;
            user.LockoutEnabled = true;

            await _userManager.UpdateAsync(user);

            return RedirectToAction(nameof(GetUsers));
        }

        public async Task<IActionResult> RemoveBanFromUser(int id)
        {
            User user = await _userManager.FindByIdAsync(id.ToString());

            user.LockoutEnabled = false;
            user.LockoutEnd = null;

            await _userManager.UpdateAsync(user);

            return RedirectToAction(nameof(GetUsers));
        }
    }
}
