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
        private readonly IMapper _mapper;
        
        public BlogController( IBlogService blogService, IMapper mapper)
        {
            _blogService = blogService;
            _mapper = mapper;
        }

        public IActionResult GetAll()
        {
            List<Blog> blogs = _blogService.GetAllByDetails();

            List<BlogViewModel> blogViewModels = new List<BlogViewModel>();

            blogViewModels = _mapper.Map(blogs, blogViewModels);
            
            return View(blogViewModels);
        }

    }
}