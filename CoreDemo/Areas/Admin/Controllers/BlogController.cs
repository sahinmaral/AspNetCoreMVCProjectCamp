using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Business.Abstract;
using CoreDemo.Models;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CoreDemo.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class BlogController : Controller
    {
        private readonly IBlogService _blogService;
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;
        private readonly ICategoryService _categoryService;
        private readonly ICommentService _commentService;
        public BlogController(IBlogService blogService, IMapper mapper, UserManager<User> userManager, ICategoryService categoryService, ICommentService commentService)
        {
            _blogService = blogService;
            _mapper = mapper;
            _userManager = userManager;
            _categoryService = categoryService;
            _commentService = commentService;
        }

        private void GetCategories()
        {
            List<SelectListItem> categoryValues = (from x in _categoryService.GetAll()
                select new SelectListItem()
                {
                    Text = x.Name,
                    Value = x.Id.ToString()
                }).ToList();

            ViewData["Categories"] = categoryValues;
        }

        private string AssignFormFileAndReturnName(IFormFile file)
        {
            var extension = Path.GetExtension(file.FileName);

            var newName = Guid.NewGuid() + extension;
            var location = Path.Combine(Directory.GetCurrentDirectory() + @"\wwwroot\images", newName);
            var stream = new FileStream(location, FileMode.Create);
            file.CopyTo(stream);
            stream.Close();

            return newName;
        }

        public async Task<IActionResult> GetBlogs()
        {
            User user = await _userManager.FindByNameAsync(User.Identity.Name);

            List <ReadBlogViewModel> viewModels = _mapper.Map(_blogService.GetAllWithDetails(x=>x.UserId != user.Id), new List<ReadBlogViewModel>());

            return View(viewModels);
        }

        [HttpGet]
        public IActionResult GetBlogDetails(int id)
        {
            Blog editedBlog = _blogService.GetByIdWithDetails(id);

            UpdateBlogViewModel blogViewModel = _mapper.Map(editedBlog, new UpdateBlogViewModel());

            GetCategories();
            return View(blogViewModel);
        }

        [HttpPost]
        public IActionResult GetBlogDetails(UpdateBlogViewModel blogViewModel)
        {
            if (!ModelState.IsValid)
            {
                GetCategories();
                return View(blogViewModel);
            }

            Blog blog = _blogService.Get(x => x.Id == blogViewModel.Id);

            string thumbnailImageName = "";
            string mainImageName = "";

            if (blogViewModel.ThumbnailImage != null)
            {
                if (System.IO.File.Exists($"{Directory.GetCurrentDirectory()}//wwwroot//images//{blog.ThumbnailImage}"))
                    System.IO.File.Delete($"{Directory.GetCurrentDirectory()}//wwwroot//images//{blog.ThumbnailImage}");
                
                thumbnailImageName = AssignFormFileAndReturnName(blogViewModel.ThumbnailImage);
                blog.ThumbnailImage = thumbnailImageName;
            }

            if (blogViewModel.MainImage != null)
            {
                if (System.IO.File.Exists($"{Directory.GetCurrentDirectory()}//wwwroot//images//{blog.MainImage}"))
                    System.IO.File.Delete($"{Directory.GetCurrentDirectory()}//wwwroot//images//{blog.MainImage}");

                mainImageName = AssignFormFileAndReturnName(blogViewModel.MainImage);
                blog.MainImage = mainImageName;
            }

            blog.Content = blogViewModel.Content;
            blog.Title = blogViewModel.Title;
            blog.CategoryId = blogViewModel.CategoryViewModel.Id;

            _blogService.Update(blog);

            return RedirectToAction("GetBlogs");
        }

        public IActionResult DeleteBlog(int id)
        {
            Blog deletedBlog = _blogService.Get(x => x.Id == id);

            deletedBlog.Status = false;
            _blogService.Update(deletedBlog);

            return RedirectToAction("GetBlogs");
        }

        public async Task<IActionResult> MyBlogs()
        {
            User user = await _userManager.FindByNameAsync(User.Identity.Name);

            List<ReadBlogViewModel> viewModels = _mapper.Map(_blogService.GetAllWithDetails(x => x.UserId == user.Id), new List<ReadBlogViewModel>());

            return View(viewModels);

        }

        [HttpGet]
        public IActionResult AddBlog()
        {
            GetCategories();

            return View(new CreateBlogViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> AddBlog(CreateBlogViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                GetCategories();
                return View(viewModel);
            }

            User user = await _userManager.FindByNameAsync(User.Identity.Name);

            string thumbnailImageName = AssignFormFileAndReturnName(viewModel.ThumbnailImage);
            string mainImageName = AssignFormFileAndReturnName(viewModel.MainImage);

            Blog newBlog = _mapper.Map(viewModel, new Blog());
            newBlog.MainImage = mainImageName;
            newBlog.ThumbnailImage = thumbnailImageName;
            newBlog.User = user;

            _blogService.Add(newBlog);

            return RedirectToAction(nameof(MyBlogs));
        }
    }
}
