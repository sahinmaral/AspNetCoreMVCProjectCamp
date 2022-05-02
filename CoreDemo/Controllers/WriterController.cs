using System;
using System.Collections.Generic;
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
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CoreDemo.Controllers
{

    [Authorize(Policy = "Writer")]
    public class WriterController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IBlogService _blogService;
        private readonly IMapper _mapper;
        private readonly UserManager<AppUser> _userManager;

        public WriterController(IBlogService blogService, IMapper mapper, ICategoryService categoryService, UserManager<AppUser> userManager)
        {
            _blogService = blogService;
            _mapper = mapper;
            _categoryService = categoryService;
            _userManager = userManager;
        }

        public IActionResult WriterProfile()
        {
            return View();
        }
        
        public async Task<IActionResult> Homepage()
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);

            return View(_mapper.Map(user, new ReadUserViewModel()));
        }

        public async Task<IActionResult> MyBlog()
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);

            List<Blog> writerBlogs = _blogService.GetAllWithDetails(x => x.UserId == user.Id).Where(x=>x.BlogStatus).ToList();

            List<ReadBlogViewModel> readBlogViewModels = new List<ReadBlogViewModel>();
            
            _mapper.Map(writerBlogs, readBlogViewModels);

            return View(readBlogViewModels);
        }

        [HttpGet]
        public async Task<IActionResult> ChangeProfile()
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);

            ReadUserViewModel viewModel = _mapper.Map(user, new ReadUserViewModel());

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> ChangeProfile(ReadUserViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }

            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            user.UserAbout = viewModel.UserAbout;

            await _userManager.UpdateAsync(user);

            return RedirectToAction("Homepage", "Writer");
        }

        [HttpGet]
        public IActionResult ChangePassword()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ChangePassword(UserPasswordViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }

            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, viewModel.NewPassword);
            
            await _userManager.UpdateAsync(user);

            return RedirectToAction("Homepage", "Writer");
        }

        [HttpGet]
        public IActionResult ChangeThumbnailImage()
        {
            return View(new UserPictureViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> ChangeThumbnailImage(UserPictureViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }

            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);

            if(user.ImageUrl != null)
                RemoveOldProfilePicture(user.ImageUrl);

            user.ImageUrl = AssignFormFileAndReturnName(viewModel.ProfilePhoto);

            await _userManager.UpdateAsync(user);

            return RedirectToAction("Homepage","Writer");
        }

        private void RemoveOldProfilePicture(string path)
        {
            System.IO.File.Delete(Directory.GetCurrentDirectory()+ @"\wwwroot\images" + path);
        }

        private string AssignFormFileAndReturnName(IFormFile file)
        {
            var extension = Path.GetExtension(file.FileName);

            var newName =  Guid.NewGuid()+ extension;
            var location = Path.Combine(Directory.GetCurrentDirectory() + @"\wwwroot\images", newName);
            var stream = new FileStream(location, FileMode.Create);
            file.CopyTo(stream);
            stream.Close();

            return newName;
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

            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);

            string thumbnailImageName = AssignFormFileAndReturnName(viewModel.BlogThumbnailImage);
            string mainImageName = AssignFormFileAndReturnName(viewModel.BlogMainImage);

            Blog newBlog= _mapper.Map(viewModel, new Blog());
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
            
            return RedirectToAction("MyBlog", "Writer");
        }

        [HttpGet]
        [Route("/Writer/UpdateBlog/{blogId}")]
        public IActionResult UpdateBlog(int blogId)
        {
            Blog editedBlog = _blogService.GetByBlogIdWithDetails(blogId);

            //blogViewModel = _mapper.Map(editedBlog, blogViewModel);
            //TODO : IFormFile maplerken sorun cikariyor. Simdilik elle yazilacak
            //    blogViewModel.BlogThumbnailImage = new FormFile(stream, 0, stream.Length, null, Path.GetFileName(stream.Name));
            //using (var stream = System.IO.File.OpenRead(Directory.GetCurrentDirectory() + @"\wwwroot\images\" + editedBlog.BlogThumbnailImage))
            //    blogViewModel.BlogMainImage = new FormFile(stream, 0, stream.Length, null, Path.GetFileName(stream.Name));
            //using (var stream = System.IO.File.OpenRead(Directory.GetCurrentDirectory() + @"\wwwroot\images\" + editedBlog.BlogMainImage))
            //TODO : Gelen dosyalari file input kismina koymamiz gerekiyor.

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
        public async Task<IActionResult> UpdateBlog(UpdateBlogViewModel blogViewModel)
        {
            if (!ModelState.IsValid)
            {
                GetCategories();
                return View(blogViewModel);
            }

            //TODO : Eger resimlerde degisiklik olmussa eskilerini silmek gerekir.
            string thumbnailImageName = AssignFormFileAndReturnName(blogViewModel.BlogThumbnailImage);
            string mainImageName = AssignFormFileAndReturnName(blogViewModel.BlogMainImage);

            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);

            Blog blog = _blogService.Get(x => x.BlogId == blogViewModel.BlogId);

            blog.UserId = user.Id;
            blog.BlogContent = blogViewModel.BlogContent;
            blog.BlogTitle = blogViewModel.BlogTitle;
            blog.CategoryId = blogViewModel.CategoryViewModel.CategoryId;
            blog.BlogMainImage = mainImageName;
            blog.BlogThumbnailImage = thumbnailImageName;

            _blogService.Update(blog);
            
            return RedirectToAction("MyBlog", "Writer");
        }
    }

    
}