using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public WriterMessagesViewComponent(IMessageService messageService,IWriterService writerService)
        {
            _messageService = messageService;
            _writerService = writerService;
        }
        public IViewComponentResult Invoke()
        {
            string loggedWriterUsername = HttpContext.User.Claims.Single().Subject.Name;

            Writer writer = _writerService.Get(x => x.WriterUsername == loggedWriterUsername);

            return View(_messageService.GetAll(x => x.ReceiverId == writer.WriterId));
        }
    }
}
