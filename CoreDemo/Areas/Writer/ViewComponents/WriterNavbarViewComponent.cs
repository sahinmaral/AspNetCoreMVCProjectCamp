using System.Threading.Tasks;
using AutoMapper;
using CoreDemo.Models;
using Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Areas.Writer.ViewComponents
{
    public class WriterNavbarViewComponent : ViewComponent
    {
        private readonly UserManager<User> _userManager; 
        private readonly IMapper _mapper;

        public WriterNavbarViewComponent(IMapper mapper, UserManager<User> userManager)
        {
            _mapper = mapper;
            _userManager = userManager;
        }
        
        public async Task<IViewComponentResult> InvokeAsync()
        {
            User user = await _userManager.FindByNameAsync(User.Identity.Name);

            ReadUserViewModel viewModel = new ReadUserViewModel();

            viewModel = _mapper.Map(user, viewModel);

            return View(viewModel);
        }
    }
}