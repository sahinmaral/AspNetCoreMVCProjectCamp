using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Business.Abstract;
using CoreDemo.Areas.Admin.Models;
using CoreDemo.Models;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace CoreDemo.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class MessageController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IMapper _mapper;
        private readonly IMessageService _messageService;
        public MessageController(IMapper mapper, UserManager<AppUser> userManager, IMessageService messageService)
        {
            _mapper = mapper;
            _userManager = userManager;
            _messageService = messageService;
        }
        public async Task<IActionResult> ViewInbox()
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);

            var messages = _messageService.GetAll(x => x.ReceiverId == user.Id);

            List<ReadMessageViewModel> viewModels = new List<ReadMessageViewModel>(messages.Count);

            viewModels = _mapper.Map(messages, viewModels);

            return View(viewModels);
        }

        public async Task<IActionResult> ViewSendBox()
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);

            var messages = _messageService.GetAll(x => x.SenderId == user.Id);

            List<ReadMessageViewModel> viewModels = new List<ReadMessageViewModel>(messages.Count);

            viewModels = _mapper.Map(messages, viewModels);

            return View(viewModels);
        }

        public IActionResult GetMessageDetail(int id)
        {
            Message message = _messageService.Get(x => x.MessageId == id);
            ReadMessageViewModel viewModel = _mapper.Map(message, new ReadMessageViewModel());
            message.MessageOpened = true;
            _messageService.Update(message);
            return View(viewModel);
        }

        [HttpGet]
        [Route("/Admin/Message/SendMessage/{receiverUsername}")]
        public async Task<IActionResult> SendMessage(string receiverUsername)
        {
            AppUser receiverUser = await _userManager.FindByNameAsync(receiverUsername);
            AppUser senderUser = await _userManager.FindByNameAsync(User.Identity.Name);

            CreateMessageViewModel viewModel = new CreateMessageViewModel();
            ReadUserViewModel receiverViewModel = _mapper.Map(receiverUser, new ReadUserViewModel());
            ReadUserViewModel senderViewModel = _mapper.Map(senderUser, new ReadUserViewModel());

            viewModel.Receiver = receiverViewModel;
            viewModel.Sender = senderViewModel;

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult SendMessage(CreateMessageViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }

            Message newMessage = _mapper.Map(viewModel, new Message());
            newMessage.ReceiverId = viewModel.Receiver.UserId;
            newMessage.SenderId = viewModel.Sender.UserId;

            _messageService.Add(newMessage);

            return RedirectToAction("ViewSendBox");
        }
    }
}
