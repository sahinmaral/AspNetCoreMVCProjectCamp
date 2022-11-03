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

            return View(viewModels);
        }

        public async Task<IActionResult> ViewSentbox()
        {
            User user = await _userManager.FindByNameAsync(User.Identity.Name);

            var messages = _messageService.GetAll(x => x.SenderId == user.Id);

            List<ReadMessageViewModel> viewModels = new List<ReadMessageViewModel>(messages.Count);

            viewModels = _mapper.Map(messages, viewModels);

            return View(viewModels);
        }

        public IActionResult GetMessageDetail(int id)
        {
            Message message = _messageService.Get(x => x.Id == id);
            ReadMessageViewModel viewModel = _mapper.Map(message, new ReadMessageViewModel());
            if(viewModel.Sender.Username != User.Identity.Name)
            {
                message.IsMessageOpened = true; _messageService.Update(message);
            }

            
            return View(viewModel);
        }

        [HttpGet]
        [Route("/Writer/Message/SendMessage/{receiverUsername}")]
        public async Task<IActionResult> SendMessage([FromRoute]string receiverUsername)
        {
            User receiverUser = await _userManager.FindByNameAsync(receiverUsername);
            User senderUser = await _userManager.FindByNameAsync(User.Identity.Name);

            CreateMessageViewModel viewModel = new CreateMessageViewModel
            {
                Receiver = _mapper.Map(receiverUser, new ReadUserViewModel()),
                Sender = _mapper.Map(senderUser, new ReadUserViewModel())
            };

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
            newMessage.ReceiverId = viewModel.Receiver.Id;
            newMessage.SenderId = viewModel.Sender.Id;

            _messageService.Add(newMessage);

            return Redirect($"/{nameof(Writer)}/{nameof(HomeController).Replace("Controller", "")}/{nameof(HomeController.Homepage)}");
        }
    }
}
