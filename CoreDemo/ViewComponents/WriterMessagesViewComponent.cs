using System;
using System.Collections.Generic;
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
    public class WriterMessagesViewComponent : ViewComponent
    {
        private readonly IMessageService _messageService;
        private readonly IMapper _mapper;
        private readonly UserManager<AppUser> _userManager;

        public WriterMessagesViewComponent(IMessageService messageService,IMapper mapper,UserManager<AppUser> userManager)
        {
            _messageService = messageService;
            _mapper = mapper;
            _userManager = userManager;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);

            var messages = _messageService.GetAll(x => x.ReceiverId == user.Id && !x.MessageOpened);

            List<ReadMessageViewModel> viewModels = new List<ReadMessageViewModel>(messages.Count);

            foreach (Message item in messages)
            {
                ReadMessageViewModel viewModel = new ReadMessageViewModel();
                viewModel = _mapper.Map(item, viewModel);
                viewModels.Add(viewModel);
            }

            return View(viewModels);
        }
    }
}
