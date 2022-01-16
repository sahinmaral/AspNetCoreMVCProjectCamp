using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Business.Abstract;
using CoreDemo.Models;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents
{
    public class WriterMessagesViewComponent : ViewComponent
    {
        private readonly IMessageService _messageService;
        private readonly IWriterService _writerService;
        private readonly IMapper _mapper;

        public WriterMessagesViewComponent(IMessageService messageService,IWriterService writerService,IMapper mapper)
        {
            _messageService = messageService;
            _writerService = writerService;
            _mapper = mapper;
        }
        public IViewComponentResult Invoke()
        {
            string loggedWriterUsername = HttpContext.User.Claims.ToArray()[0].Subject.Name;

            Writer writer = _writerService.Get(x => x.User.Username == loggedWriterUsername);

            var messages = _messageService.GetAll(x => x.ReceiverId == writer.User.UserId);

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
