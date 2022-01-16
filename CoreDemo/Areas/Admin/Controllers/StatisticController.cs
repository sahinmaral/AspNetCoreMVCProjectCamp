using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Business.Abstract;
using CoreDemo.Models;
using Entities.Concrete;

namespace CoreDemo.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class StatisticController : Controller
    {
        private readonly IBlogService _blogService;
        private readonly IContactService _contactService;
        private readonly IMessageService _messageService;
        private readonly IAdminService _adminService;
        private readonly ICommentService _commentService;
        private readonly IMapper _mapper;

        public StatisticController(IBlogService blogService,
            IContactService contactService,
            IMessageService messageService,
            IAdminService adminService,
            ICommentService commentService,
            IMapper mapper)
        {
            _blogService = blogService;
            _contactService = contactService;
            _messageService = messageService;
            _adminService = adminService;
            _commentService = commentService;
            _mapper = mapper;
        }
        public IActionResult GetStatistics()
        {
            string loggedWriterUsername = HttpContext.User.Claims.ToArray()[0].Subject.Name;

            Entities.Concrete.Admin admin = _adminService.Get(x => x.User.Username == loggedWriterUsername);

            ReadBlogViewModel lastBlogViewModel = new ReadBlogViewModel();
            lastBlogViewModel = _mapper.Map(_blogService.GetAllWithDetails().OrderByDescending(x => x.BlogCreatedDate).First(), lastBlogViewModel);

            ReadStatisticsViewModel viewModel = new ReadStatisticsViewModel
            {
                TotalBlogCount = _blogService.GetAllWithDetails().Count,
                NewContactCount = _contactService.GetAll(x=>x.ContactStatus).Count,
                NewMessageCount = _messageService.GetAll(x=>x.Receiver.User.Username == admin.User.Username && x.MessageOpened == false).Count,
                TotalCommentCount = _commentService.GetAll(x=>x.CommentStatus).Count,
                LastBlog = lastBlogViewModel
            };
            return View(viewModel);
        }
    }
}
