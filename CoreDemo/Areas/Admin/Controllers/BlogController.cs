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
                    Text = x.CategoryName,
                    Value = x.CategoryId.ToString()
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

        public IActionResult GetBlogs()
        {
            List<ReadBlogViewModel> viewModels = _mapper.Map(_blogService.GetAllWithDetails(), new List<ReadBlogViewModel>());

            return View(viewModels);
        }

        [HttpGet]
        public IActionResult GetBlogDetails(int id)
        {
            Blog editedBlog = _blogService.GetByBlogIdWithDetails(id);

            UpdateBlogViewModel blogViewModel = new UpdateBlogViewModel
            {
                BlogId = editedBlog.BlogId,
                BlogTitle = editedBlog.BlogTitle,
                BlogContent = editedBlog.BlogContent,
                BlogCreateDate = Convert.ToString(editedBlog.BlogCreatedDate, CultureInfo.InvariantCulture),
                BlogStatus = editedBlog.BlogStatus,
                CategoryViewModel = _mapper.Map(editedBlog.Category, new ReadCategoryViewModel()),
                WriterViewModel = _mapper.Map(editedBlog.User, new ReadUserViewModel()),
                CommentViewModels = _mapper.Map(editedBlog.Comments, new List<ReadCommentViewModel>())
            };

            GetCategories();
            return View(blogViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> GetBlogDetails(UpdateBlogViewModel blogViewModel)
        {
            if (!ModelState.IsValid)
            {
                GetCategories();
                return View(blogViewModel);
            }

            //TODO : Eger resimlerde degisiklik olmussa eskilerini silmek gerekir.
            string thumbnailImageName = AssignFormFileAndReturnName(blogViewModel.BlogThumbnailImage);
            string mainImageName = AssignFormFileAndReturnName(blogViewModel.BlogMainImage);

            User user = await _userManager.FindByNameAsync(User.Identity.Name);

            Blog blog = _blogService.Get(x => x.BlogId == blogViewModel.BlogId);

            blog.UserId = user.Id;
            blog.BlogContent = blogViewModel.BlogContent;
            blog.BlogTitle = blogViewModel.BlogTitle;
            blog.CategoryId = blogViewModel.CategoryViewModel.CategoryId;
            blog.BlogMainImage = mainImageName;
            blog.BlogThumbnailImage = thumbnailImageName;

            _blogService.Update(blog);

            return RedirectToAction("GetBlogs");
        }

        public IActionResult DeleteBlog(int id)
        {
            Blog deletedBlog = _blogService.Get(x => x.BlogId == id);

            foreach (Comment comment in _commentService.GetAll(x=>x.BlogId == deletedBlog.BlogId))
                _commentService.Delete(comment);

            _blogService.Delete(deletedBlog);

            return RedirectToAction("GetBlogs");
        }
    }
}
