using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Business.Abstract;
using CoreDemo.Models;
using Entities.Concrete;

namespace CoreDemo.Controllers
{
    public class MessageController : Controller
    {
        private readonly IMessageService _messageService;
        private readonly IWriterService _writerService;
        private readonly IMapper _mapper;

        public MessageController(IMessageService messageService, IWriterService writerService, IMapper mapper)
        {
            _messageService = messageService;
            _writerService = writerService;
            _mapper = mapper;
        }
        public IActionResult ViewInbox()
        {
            string loggedWriterUsername = HttpContext.User.Claims.ToArray()[0].Subject.Name;

            Writer writer = _writerService.Get(x => x.User.Username == loggedWriterUsername);

            var messages = _messageService.GetAll(x => x.ReceiverId == writer.User.UserId);

            List<ReadMessageViewModel> viewModels = new List<ReadMessageViewModel>(messages.Count);

            foreach (var message in messages)
            {
                ReadMessageViewModel viewModel = new ReadMessageViewModel();
                viewModel = _mapper.Map(message, viewModel);
                viewModels.Add(viewModel);
            }

            return View(viewModels);
        }

        public IActionResult GetMessageDetail(int id)
        {
            return View(_mapper.Map(_messageService.Get(x => x.MessageId == id), new ReadMessageViewModel()));
        }
    }
}
