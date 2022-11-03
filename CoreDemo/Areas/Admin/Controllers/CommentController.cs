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

        public IActionResult GetCommentsByBlog(string slug)
        {
            List<Comment> comments = _commentService.GetAllWithDetails(x => x.Blog.Slug == slug);
            List<ReadCommentViewModel> viewModels = _mapper.Map(comments, new List<ReadCommentViewModel>());

            ViewData["CommentBlogTitle"] = _blogService.GetBySlugWithDetails(slug).Title;
            return View(viewModels);
        }

        public IActionResult DeleteComment(int id)
        {
            Comment deletedComment = _commentService.Get(x => x.Id == id);
            _commentService.Delete(deletedComment);

            return RedirectToAction("GetBlogs","Blog");
        }

        [HttpGet]
        public IActionResult UpdateComment(int id)
        {
            Comment comment = _commentService.Get(x => x.Id == id);
            Blog blog = _blogService.Get(x => x.Id == comment.BlogId);
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
            Comment comment = _commentService.Get(x => x.Id == viewModel.Id);

            comment.Detail = viewModel.Detail;
            _commentService.Update(comment);

            return RedirectToAction(nameof(GetCommentsByBlog), new { id = viewModel.BlogId });
        }
    }
}
