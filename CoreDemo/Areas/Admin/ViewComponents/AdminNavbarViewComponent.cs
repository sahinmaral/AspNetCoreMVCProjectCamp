using System.Collections.Generic;
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
    public class AdminNavbarViewComponent : ViewComponent
    {
        private readonly IMessageService _messageService;
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;
        public AdminNavbarViewComponent(IMessageService messageService, IMapper mapper, UserManager<User> userManager)
        {
            _messageService = messageService;
            _mapper = mapper;
            _userManager = userManager;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            User user = await _userManager.FindByNameAsync(User.Identity.Name);

            List<Message> messages = _messageService.GetAll(x => x.ReceiverId == user.Id && !x.IsMessageOpened);

            List<ReadMessageViewModel> readMessageViewModels = _mapper.Map(messages, new List<ReadMessageViewModel>());

            AdminNavbarViewModel viewModel = new AdminNavbarViewModel
            {
                ReadMessageViewModels = readMessageViewModels
            };

            return View(viewModel);
        }
    }
}