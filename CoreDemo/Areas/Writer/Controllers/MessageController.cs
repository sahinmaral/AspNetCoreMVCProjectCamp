using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Business.Abstract;
using CoreDemo.Models;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace CoreDemo.Areas.Writer.Controllers
{
    [Authorize(Roles = "Writer")]
    [Area("Writer")]
    public class MessageController : Controller
    {
        private readonly IMessageService _messageService;
        private readonly UserManager<User> _userManager;
        private readonly IMapper _mapper;

        public MessageController(IMessageService messageService, IMapper mapper, UserManager<User> userManager)
        {
            _messageService = messageService;
            _mapper = mapper;
            _userManager = userManager;
        }
        public async Task<IActionResult> ViewInbox()
        {
            User user = await _userManager.FindByNameAsync(User.Identity.Name);

            var messages = _messageService.GetAll(x => x.ReceiverId == user.Id);

            List<ReadMessageViewModel> viewModels = new List<ReadMessageViewModel>(messages.Count);

            viewModels = _mapper.Map(messages, viewModels);

            //foreach (var message in messages)
            //{
            //    ReadMessageViewModel viewModel = new ReadMessageViewModel();
            //    viewModel = _mapper.Map(message, viewModel);
            //    viewModels.Add(viewModel);
            //}

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
        [Route("/Writer/Message/SendMessage/{receiverUsername}")]
        public async Task<IActionResult> SendMessage(string receiverUsername)
        {
            User receiverUser = await _userManager.FindByNameAsync(receiverUsername);
            User senderUser = await _userManager.FindByNameAsync(User.Identity.Name);

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

            return RedirectToAction("Homepage", "Home");
        }
    }
}
