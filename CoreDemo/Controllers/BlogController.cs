using System.Collections.Generic;
using System.Diagnostics;
using AutoMapper;
using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CoreDemo.Models;
using Entities.Concrete;

namespace CoreDemo.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlogService _blogService;
        private readonly ICommentService _commentService;
        private readonly IMapper _mapper;
        
        public BlogController( IBlogService blogService, ICommentService commentService , IMapper mapper)
        {
            _blogService = blogService;
            _commentService = commentService;
            _mapper = mapper;
        }

        public IActionResult GetAll()
        {
            List<Blog> blogs = _blogService.GetAllByDetails();

            List<BlogViewModel> blogViewModels = new List<BlogViewModel>();

            blogViewModels = _mapper.Map(blogs, blogViewModels);
            
            return View(blogViewModels);
        }

        public IActionResult GetById([FromRoute]int id)
        {
            Blog blog = _blogService.Get(x => x.BlogId == id);
            List<Comment> comments = _commentService.GetAll(x => x.BlogId == id);
            blog.Comments = comments;
            
            BlogViewModel blogViewModel = new BlogViewModel();
            List<CommentViewModel> commentViewModels = new List<CommentViewModel>();

            blogViewModel = _mapper.Map(blog, blogViewModel);
            commentViewModels = _mapper.Map(comments, commentViewModels);

            return View(blogViewModel);
        }

        public PartialViewResult GetCommentsByBlog()
        {
            return PartialView();
        }

        public PartialViewResult AddComment()
        {
            return PartialView();
        }
    }
}