using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Business.Abstract;
using Business.Concrete;
using CoreDemo.Models;
using Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents
{
    public class LoginRegisterNavbarViewComponent : ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IMapper _mapper;

        public LoginRegisterNavbarViewComponent(IMapper mapper, UserManager<AppUser> userManager)
        {
            _mapper = mapper;
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            if (User.Identity.Name == null)
                return View(new ReadUserViewModel());

            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);

            ReadUserViewModel viewModel = new ReadUserViewModel();

            viewModel = _mapper.Map(user, viewModel);

            return View(viewModel);
        }
    }
}