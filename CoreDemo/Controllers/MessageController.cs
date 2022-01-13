using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;

namespace CoreDemo.Controllers
{
    public class MessageController : Controller
    {
        private readonly IMessageService _messageService;
        private readonly IWriterService _writerService;

        public MessageController(IMessageService messageService,IWriterService writerService)
        {
            _messageService = messageService;
            _writerService = writerService;
        }
        public IActionResult ViewInbox()
        {
            string loggedWriterUsername = HttpContext.User.Claims.Single().Subject.Name;

            Writer writer = _writerService.Get(x => x.WriterUsername == loggedWriterUsername);

            return View(_messageService.GetAll(x => x.ReceiverId == writer.WriterId));
        }

        public IActionResult GetMessageDetail(int id)
        {
            return View(_messageService.Get(x=>x.MessageId == id));
        }
    }
}
