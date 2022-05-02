using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using AutoMapper;

using Business.Abstract;

using CoreDemo.Areas.Admin.Models;

using Entities.Concrete;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace CoreDemo.Areas.Admin.ViewComponents
{
    public class MessageSideBarViewComponent : ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IMessageService _messageService;
        public MessageSideBarViewComponent(UserManager<AppUser> userManager, IMessageService messageService)
        {
            _userManager = userManager;
            _messageService = messageService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);

            List<Message> messages = _messageService.GetAll();

            MessageTypeCountViewModel viewModel = new MessageTypeCountViewModel
            {
                ReceivedMessageCount = messages.Count(x => x.ReceiverId == user.Id),
                SentMessageCount = messages.Count(x => x.SenderId == user.Id)
            };

            return View(viewModel);
        }
    }
}
