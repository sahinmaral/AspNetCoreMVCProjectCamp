using AutoMapper;

using Business.Abstract;
using CoreDemo.Models;
using Entities.Concrete;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Areas.Writer.Controllers
{
    [Authorize(Roles = "Writer")]
    [Area("Writer")]
    public class BlogController : Controller
    {
        private readonly IBlogService _blogService;
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;
        private readonly ICategoryService _categoryService;

        public BlogController(IBlogService blogService, IMapper mapper,  UserManager<User> userManager, ICategoryService categoryService)
        {
            _blogService = blogService;
            _mapper = mapper;
            _userManager = userManager;
            _categoryService = categoryService;
        }
        public async Task<IActionResult> MyBlog()
        {
            User user = await _userManager.FindByNameAsync(User.Identity.Name);

            List<Blog> writerBlogs = _blogService.GetAllWithDetails(x => x.UserId == user.Id).Where(x => x.BlogStatus).ToList();

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
        public async Task<IActionResult> AddBlog(CreateBlogViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                GetCategories();
                return View(viewModel);
            }

            User user = await _userManager.FindByNameAsync(User.Identity.Name);

            string thumbnailImageName = AssignFormFileAndReturnName(viewModel.BlogThumbnailImage);
            string mainImageName = AssignFormFileAndReturnName(viewModel.BlogMainImage);

            Blog newBlog = _mapper.Map(viewModel, new Blog());
            newBlog.BlogMainImage = mainImageName;
            newBlog.BlogThumbnailImage = thumbnailImageName;
            newBlog.User = user;

            _blogService.Add(newBlog);

            return RedirectToAction("MyBlog");
        }

        [Route("/Writer/DeleteBlog/{blogId}")]
        public IActionResult DeleteBlog(int blogId)
        {
            Blog deletedBlog = _blogService.Get(x => x.BlogId == blogId);
            _blogService.Delete(deletedBlog);

            return RedirectToAction("MyBlog", "Blog");
        }

        [HttpGet]
        [Route("/Writer/UpdateBlog/{blogId}")]
        public IActionResult UpdateBlog(int blogId)
        {
            Blog editedBlog = _blogService.GetByBlogIdWithDetails(blogId);

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
        public IActionResult UpdateBlog(UpdateBlogViewModel blogViewModel)
        {
            if (!ModelState.IsValid)
            {
                GetCategories();
                return View(blogViewModel);
            }

            Blog blog = _blogService.Get(x => x.BlogId == blogViewModel.BlogId);

            string thumbnailImageName = "";
            string mainImageName = "";

            if (blogViewModel.BlogThumbnailImage != null)
            {
                if (System.IO.File.Exists($"{Directory.GetCurrentDirectory()}//wwwroot//images//{blog.BlogThumbnailImage}"))
                    System.IO.File.Delete($"{Directory.GetCurrentDirectory()}//wwwroot//images//{blog.BlogThumbnailImage}");

                thumbnailImageName = AssignFormFileAndReturnName(blogViewModel.BlogThumbnailImage);
                blog.BlogThumbnailImage = thumbnailImageName;
            }

            if (blogViewModel.BlogMainImage != null)
            {
                if (System.IO.File.Exists($"{Directory.GetCurrentDirectory()}//wwwroot//images//{blog.BlogMainImage}"))
                    System.IO.File.Delete($"{Directory.GetCurrentDirectory()}//wwwroot//images//{blog.BlogMainImage}");

                mainImageName = AssignFormFileAndReturnName(blogViewModel.BlogMainImage);
                blog.BlogMainImage = mainImageName;
            }

            blog.BlogContent = blogViewModel.BlogContent;
            blog.BlogTitle = blogViewModel.BlogTitle;
            blog.CategoryId = blogViewModel.CategoryViewModel.CategoryId;

            _blogService.Update(blog);

            return RedirectToAction("MyBlog", "Blog");
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
    }
}
