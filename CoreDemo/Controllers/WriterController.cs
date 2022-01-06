using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using AutoMapper;
using Business.Abstract;
using CoreDemo.Models;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
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
            string loggedWriterUsername = HttpContext.User.Claims.Single().Subject.Name;
            Writer writer = _writerService.Get(x => x.WriterUsername == loggedWriterUsername);
            return View(_mapper.Map(writer, new ReadWriterViewModel()));
        }

        public IActionResult MyBlog()
        {
            string loggedWriterUsername = HttpContext.User.Claims.Single().Subject.Name;
            Writer writer = _writerService.Get(x => x.WriterUsername == loggedWriterUsername);

            List<Blog> writerBlogs = _blogService.GetAllWithDetails(x => x.Writer.WriterId == writer.WriterId).Where(x=>x.BlogStatus).ToList();

            List<ReadBlogViewModel> readBlogViewModels = new List<ReadBlogViewModel>();
            
            _mapper.Map(writerBlogs, readBlogViewModels);

            return View(readBlogViewModels);
        }

        [HttpGet]
        public IActionResult ChangeProfile()
        {
            string loggedWriterUsername = HttpContext.User.Claims.Single().Subject.Name;
            Writer writer = _writerService.Get(x => x.WriterUsername == loggedWriterUsername);

            ReadWriterViewModel model = new ReadWriterViewModel();

            model = _mapper.Map(writer, model);

            return View(model);
        }

        [HttpPost]
        public IActionResult ChangeProfile(ReadWriterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            string loggedWriterUsername = HttpContext.User.Claims.Single().Subject.Name;
            Writer updatedWriter = _writerService.Get(x => x.WriterUsername == loggedWriterUsername);

            updatedWriter.WriterSurname = model.WriterSurname;
            updatedWriter.WriterName = model.WriterName;
            updatedWriter.WriterAbout = model.WriterAbout;

            _writerService.Update(updatedWriter);

            return RedirectToAction("Homepage", "Writer");
        }

        [HttpGet]
        public IActionResult ChangePassword()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ChangePassword(WriterPasswordViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            string loggedWriterUsername = HttpContext.User.Claims.Single().Subject.Name;
            Writer updatedWriter = _writerService.Get(x => x.WriterUsername == loggedWriterUsername);

            if (updatedWriter.WriterPassword != model.OldPassword)
            {
                ModelState.AddModelError("OldPassword", "Yanlış şifre girdiniz");
                return View(model);
            }

            updatedWriter.WriterPassword = model.NewPassword;

            _writerService.Update(updatedWriter);

            return RedirectToAction("Homepage", "Writer");
        }

        [HttpGet]
        public IActionResult ChangeProfileImage()
        {
            return View(new WriterProfilePhotoViewModel());
        }

        [HttpPost]
        public IActionResult ChangeProfileImage(WriterProfilePhotoViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            string loggedWriterUsername = HttpContext.User.Claims.Single().Subject.Name;
            Writer updatedWriter = _writerService.Get(x => x.WriterUsername == loggedWriterUsername);

            RemoveOldProfilePicture(updatedWriter.WriterImage);

            updatedWriter.WriterImage = AssignFormFileAndReturnName(model.ProfilePhoto);

            _writerService.Update(updatedWriter);

            return RedirectToAction("Homepage","Writer");
        }

        private void RemoveOldProfilePicture(string path)
        {
            System.IO.File.Delete(Directory.GetCurrentDirectory()+ @"\wwwroot\writerProfileImages\" + path);
        }

        private string AssignFormFileAndReturnName(IFormFile file)
        {
            var extension = Path.GetExtension(file.FileName);

            var newName =  Guid.NewGuid()+ extension;
            var location = Path.Combine(Directory.GetCurrentDirectory() + @"\wwwroot\writerProfileImages\", newName);
            var stream = new FileStream(location, FileMode.Create);
            file.CopyTo(stream);

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
        public IActionResult AddBlog(CreateBlogViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                GetCategories();
                return View(viewModel);
            }

            string loggedWriterUsername = HttpContext.User.Claims.Single().Subject.Name;
            Writer writer = _writerService.Get(x => x.WriterUsername == loggedWriterUsername);

            Blog blog = new Blog
            {
                WriterId = writer.WriterId,
                CategoryId = viewModel.CategoryId
            };

            _mapper.Map(viewModel, blog);
            
            _blogService.Add(blog);
            
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

            UpdateBlogViewModel blogViewModel = new UpdateBlogViewModel();

            blogViewModel = _mapper.Map(editedBlog, blogViewModel);
            
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

            string loggedWriterUsername = HttpContext.User.Claims.Single().Subject.Name;
            Writer writer = _writerService.Get(x => x.WriterUsername == loggedWriterUsername);

            Blog blog = _blogService.Get(x => x.BlogId == blogViewModel.BlogId);

            blog.WriterId = writer.WriterId;
            blog.CategoryId = blogViewModel.CategoryViewModel.CategoryId;

            blog = _mapper.Map(blogViewModel, blog);
            
            _blogService.Update(blog);
            
            return RedirectToAction("MyBlog", "Writer");
        }
    }

    
}