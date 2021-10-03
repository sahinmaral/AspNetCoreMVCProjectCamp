﻿using AutoMapper;

using Business.Abstract;

using CoreDemo.Models;

using Entities.Concrete;

using Microsoft.AspNetCore.Mvc;

using System.Collections.Generic;

namespace CoreDemo.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlogService _blogService;
        private readonly ICommentService _commentService;
        private readonly IMapper _mapper;
        
        public BlogController(IBlogService blogService, ICommentService commentService , IMapper mapper)
        {
            _blogService = blogService;
            _commentService = commentService;
            _mapper = mapper;
        }

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

        [Route("/Blog/GetById/{blogId}")]
        public IActionResult GetById(int blogId)
        {
            Blog blog = _blogService.GetByBlogIdWithDetails(blogId);
            List<Comment> comments = _commentService.GetAllWithDetails(x => x.BlogId == blogId);
            
            
            ReadBlogViewModel blogViewModel = new ReadBlogViewModel();
            List<ReadCommentViewModel> commentViewModels = new List<ReadCommentViewModel>();

            blogViewModel = _mapper.Map(blog, blogViewModel);
            commentViewModels = _mapper.Map(comments, commentViewModels);

            blogViewModel.CommentViewModels = commentViewModels;

            return View(blogViewModel);
        }

        public PartialViewResult AddComment()
        {
            return PartialView();
        }
    }
}