using AutoMapper;
using Business.Abstract;
using CoreDemo.Models;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Helper.Toastr;
using Core.Helper.Toastr.OptionEnums;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace CoreDemo.Controllers
{
    [AllowAnonymous]
    public class BlogController : Controller
    {
        private readonly IBlogService _blogService;
        private readonly ICommentService _commentService;
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;

        public BlogController(IBlogService blogService, ICommentService commentService, IMapper mapper, UserManager<User> userManager)
        {
            _blogService = blogService;
            _commentService = commentService;
            _mapper = mapper;
            _userManager = userManager;
        }


        public IActionResult GetAll()
        {
            List<Blog> blogs = _blogService.GetAllWithDetails();

            List<ReadBlogViewModel> blogViewModels = new List<ReadBlogViewModel>();

            blogViewModels = _mapper.Map(blogs, blogViewModels);

            return View(blogViewModels);
        }


        [Route("/Blog/GetById/{blogId}")] 
        public IActionResult GetById(int blogId)
        {
            TempData["BlogId"] = blogId;

            Blog blog = _blogService.GetByBlogIdWithDetails(blogId);
           
            ReadBlogViewModel blogViewModel = new ReadBlogViewModel();
            blogViewModel = _mapper.Map(blog, blogViewModel);

            ReadUserViewModel userViewModel = _mapper.Map(blog.User, new ReadUserViewModel());
            List<ReadCommentViewModel> commentViewModels = _mapper.Map(blog.Comments, new List<ReadCommentViewModel>());

            blogViewModel.CommentViewModels = commentViewModels;
            blogViewModel.UserViewModel = userViewModel;

            return View(blogViewModel);
        }


        [HttpPost]
        public async Task<IActionResult> AddComment(CreateCommentViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                TempData["Message"] = ToastrNotification.Show("message", position: Position.BottomRight,
                    type: ToastType.error);

                return RedirectToRoute(new
                {
                    controller = "Blog",
                    action = "GetById",
                    blogId = viewModel.BlogId
                });
            }

            if (User.Identity.Name == null)
            {
                TempData["Message"] = ToastrNotification.Show("Yorum yapmak icin giris yapiniz.", position: Position.BottomRight,
                    type: ToastType.error);

                return RedirectToRoute(new
                {
                    controller = "Blog",
                    action = "GetById",
                    blogId = viewModel.BlogId
                });
            }
            
            User user = await _userManager.FindByNameAsync(User.Identity.Name);
            viewModel.UserId = user.Id;

            Comment addedComment = new Comment();

            addedComment = _mapper.Map(viewModel, addedComment);

            _commentService.Add(addedComment);

            TempData["Message"] = ToastrNotification.Show("Başarıyla yorum gönderdiniz", position: Position.BottomRight,
                type: ToastType.success);

            return RedirectToRoute(new
            {
                controller = "Blog",
                action = "GetById",
                blogId = viewModel.BlogId
            });
        }
    }
}