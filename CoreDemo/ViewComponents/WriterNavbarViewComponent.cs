using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Business.Abstract;
using CoreDemo.Models;
using Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents
{
    public class WriterNavbarViewComponent : ViewComponent
    {
        private readonly UserManager<AppUser> _userManager; 
        private readonly IMapper _mapper;

        public WriterNavbarViewComponent(IMapper mapper, UserManager<AppUser> userManager)
        {
            _mapper = mapper;
            _userManager = userManager;
        }
        
        public async Task<IViewComponentResult> InvokeAsync()
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);

            ReadUserViewModel viewModel = new ReadUserViewModel();

            viewModel = _mapper.Map(user, viewModel);

            return View(viewModel);
        }
    }
}