using AutoMapper;
using Business.Abstract;
using CoreDemo.Models;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Core.Helper.Toastr;
using Core.Helper.Toastr.OptionEnums;
using Microsoft.AspNetCore.Authorization;

namespace CoreDemo.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlogService _blogService;
        private readonly ICommentService _commentService;
        private readonly IMapper _mapper;
        private readonly IWriterService _writerService;

        public BlogController(IBlogService blogService, ICommentService commentService, IMapper mapper,
            IWriterService writerService)
        {
            _blogService = blogService;
            _commentService = commentService;
            _mapper = mapper;
            _writerService = writerService;
        }

        [AllowAnonymous]
        public IActionResult GetAll()
        {
            List<Blog> blogs = _blogService.GetAllWithDetails();

            List<ReadBlogViewModel> blogViewModels = new List<ReadBlogViewModel>();

            foreach (Blog blog in blogs)
            {
                blog.Comments = new List<Comment>();

                foreach (Comment comment in _commentService.GetAll())
                {
                    if (comment.BlogId == blog.BlogId)
                    {
                        blog.Comments.Add(comment);
                    }
                }
            }

            blogViewModels = _mapper.Map(blogs, blogViewModels);

            return View(blogViewModels);
        }

        [AllowAnonymous]
        [Route("/Blog/GetById/{blogId}")]
        public IActionResult GetById(int blogId)
        {
            TempData["BlogId"] = blogId;

            Blog blog = _blogService.GetByBlogIdWithDetails(blogId);
            List<Comment> comments = _commentService.GetAllWithDetails(x => x.BlogId == blogId);

            ReadBlogViewModel blogViewModel = new ReadBlogViewModel();
            List<ReadCommentViewModel> commentViewModels = new List<ReadCommentViewModel>();

            blogViewModel = _mapper.Map(blog, blogViewModel);
            commentViewModels = _mapper.Map(comments, commentViewModels);

            blogViewModel.CommentViewModels = commentViewModels;

            return View(blogViewModel);
        }


        [HttpGet]
        public PartialViewResult AddComment()
        {
            return PartialView();
        }

        [HttpPost]
        public IActionResult AddComment(CreateCommentViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                // TODO - ModelState uyarı verince , toplam uyarılar mesajın içerisinde olsun.
                TempData["Message"] = ToastrNotification.Show("message", position: Position.BottomRight,
                    type: ToastType.error);
                
                return RedirectToRoute(new
                {
                    controller = "Blog",
                    action = "GetById",
                    blogId = viewModel.BlogId
                });
            }

            string loggedWriterUsername = HttpContext.User.Claims.ToArray()[0].Subject.Name;

            Writer writer = _writerService.Get(x => x.User.UserFirstName == loggedWriterUsername);

            viewModel.WriterId = writer.User.UserId;

            Comment addedComment = new Comment();

            addedComment = _mapper.Map(viewModel, addedComment);

            _commentService.Add(addedComment);

            TempData["Message"] = ToastrNotification.Show("Başarıyla yorum gönderdiniz", position: Position.BottomRight,
                type: ToastType.success);

            return RedirectToRoute(new
            {
                controller = "Blog",
                action = "GetById",
                blogId = viewModel.BlogId
            });
        }
    }
}