using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Business.Abstract;
using CoreDemo.Areas.Admin.Models;
using CoreDemo.Models;
using Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Areas.Admin.ViewComponents
{
    public class AdminSidebarViewComponent : ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IMapper _mapper;
        private readonly IMessageService _messageService;

        public AdminSidebarViewComponent(UserManager<AppUser> userManager, IMapper mapper, IMessageService messageService)
        {
            _userManager = userManager;
            _mapper = mapper;
            _messageService = messageService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            ReadUserViewModel userViewModel = _mapper.Map(user, new ReadUserViewModel());

            return View(userViewModel);
        }
    }
}