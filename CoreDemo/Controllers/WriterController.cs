using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Business.Abstract;
using CoreDemo.Models;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CoreDemo.Controllers
{

    public class WriterController : Controller
    {
        private readonly IWriterService _writerService;
        private readonly ICategoryService _categoryService;
        private readonly IBlogService _blogService;
        private readonly IMapper _mapper;

        public WriterController(IWriterService writerService, IBlogService blogService, IMapper mapper, ICategoryService categoryService)
        {
            _writerService = writerService;
            _blogService = blogService;
            _mapper = mapper;
            _categoryService = categoryService;
        }

        public IActionResult WriterProfile()
        {
            return View();
        }
        
        public IActionResult Homepage()
        {
            return View();
        }

        public IActionResult MyBlog()
        {
            string loggedWriterUsername = HttpContext.User.Claims.Single().Subject.Name;

            Writer writer = _writerService.Get(x => x.WriterUsername == loggedWriterUsername);

            List<Blog> writerBlogs = _blogService.GetAllWithDetails(x => x.WriterId == writer.WriterId);

            List<ReadBlogViewModel> readBlogViewModels = new List<ReadBlogViewModel>();
            
            _mapper.Map(writerBlogs, readBlogViewModels);

            return View(readBlogViewModels);
        }

        [HttpGet]
        public IActionResult AddBlog()
        {
            GetCategories();

            return View(new CreateBlogViewModel());
        }

        private void GetCategories()
        {
            List<SelectListItem> categoryValues = (from x in _categoryService.GetAll()
                select new SelectListItem()
                {
                    Text = x.CategoryName,
                    Value = x.CategoryId.ToString()
                }).ToList();

            ViewData["Categories"] = categoryValues;
        }

        [HttpPost]
        public IActionResult AddBlog(CreateBlogViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                GetCategories();
                return View(viewModel);
            }
            
            string loggedWriterUsername = HttpContext.User.Claims.Single().Subject.Name;

            Writer writer = _writerService.Get(x => x.WriterUsername == loggedWriterUsername);

            Blog blog = new Blog();

            blog.WriterId = writer.WriterId;
            blog.CategoryId = viewModel.CategoryId;

            _mapper.Map(viewModel, blog);
            
            _blogService.Add(blog);
            
            return RedirectToAction("MyBlog");
        }
    }
}