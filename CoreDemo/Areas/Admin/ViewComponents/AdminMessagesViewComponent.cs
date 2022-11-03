using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Business.Abstract;
using CoreDemo.Models;
using Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Areas.Admin.ViewComponents
{
    public class AdminMessagesViewComponent : ViewComponent
    {
        private readonly IMessageService _messageService;
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;

        public AdminMessagesViewComponent(IMessageService messageService,IMapper mapper,UserManager<User> userManager)
        {
            _messageService = messageService;
            _mapper = mapper;
            _userManager = userManager;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            User user = await _userManager.FindByNameAsync(User.Identity.Name);

            var messages = _messageService.GetAll(x => x.ReceiverId == user.Id && !x.IsMessageOpened);

            List<ReadMessageViewModel> viewModels = new List<ReadMessageViewModel>(messages.Count);

            viewModels = _mapper.Map(messages, viewModels);

            return View(viewModels);
        }
    }
}
