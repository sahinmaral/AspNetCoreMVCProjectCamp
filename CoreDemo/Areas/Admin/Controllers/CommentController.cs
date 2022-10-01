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

namespace CoreDemo.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;
        private readonly IBlogService _blogService;
        private readonly IMapper _mapper;
        public CommentController(ICommentService commentService, IMapper mapper, IBlogService blogService)
        {
            _commentService = commentService;
            _mapper = mapper;
            _blogService = blogService;
        }

        public IActionResult GetCommentsByBlog(int id)
        {
            List<Comment> comments = _commentService.GetAllWithDetails(x => x.BlogId == id);
            List<ReadCommentViewModel> viewModels = _mapper.Map(comments, new List<ReadCommentViewModel>());

            ViewData["CommentBlogTitle"] = _blogService.GetByBlogIdWithDetails(id).BlogTitle;
            return View(viewModels);
        }

        public IActionResult DeleteComment(int id)
        {
            Comment deletedComment = _commentService.Get(x => x.CommentId == id);
            _commentService.Delete(deletedComment);

            return RedirectToAction("GetBlogs","Blog");
        }

        [HttpGet]
        public IActionResult UpdateComment(int id)
        {
            Comment comment = _commentService.Get(x => x.CommentId == id);
            Blog blog = _blogService.Get(x => x.BlogId == comment.BlogId);
            comment.Blog = blog;

            return View(_mapper.Map(comment,new UpdateCommentViewModel()));
        }

        [HttpPost]
        public IActionResult UpdateComment(UpdateCommentViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }
            Comment comment = _commentService.Get(x => x.CommentId == viewModel.CommentId);

            comment.CommentAbout = viewModel.CommentAbout;
            _commentService.Update(comment);

            return RedirectToAction("GetCommentsByBlog", new { id = viewModel.BlogId });
        }
    }
}
