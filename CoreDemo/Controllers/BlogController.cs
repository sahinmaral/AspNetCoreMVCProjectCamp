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
    public class BlogController : Controller
    {
        private readonly IBlogService _blogService;
        private readonly ICommentService _commentService;
        private readonly IMapper _mapper;
        private readonly UserManager<AppUser> _userManager;

        public BlogController(IBlogService blogService, ICommentService commentService, IMapper mapper, UserManager<AppUser> userManager)
        {
            _blogService = blogService;
            _commentService = commentService;
            _mapper = mapper;
            _userManager = userManager;
        }

        [AllowAnonymous]
        public IActionResult GetAll()
        {
            List<Blog> blogs = _blogService.GetAllWithDetails();

            List<ReadBlogViewModel> blogViewModels = new List<ReadBlogViewModel>();

            //TODO : Blog icerisinde yorumlar iliskisi varken neden burada foreach yazdim ?

            blogViewModels = _mapper.Map(blogs, blogViewModels);

            return View(blogViewModels);
        }

        [AllowAnonymous]
        [Route("/Blog/GetById/{blogId}")] 
        public IActionResult GetById(int blogId)
        {
            TempData["BlogId"] = blogId;

            //TODO : Bloglari aldigi zaman neden yorumlari da almiyor , incele.

            Blog blog = _blogService.GetByBlogIdWithDetails(blogId);
            List<Comment> comments = _commentService.GetAllWithDetails(x => x.BlogId == blogId);

            ReadBlogViewModel blogViewModel = new ReadBlogViewModel();
            List<ReadCommentViewModel> commentViewModels = new List<ReadCommentViewModel>();

            ReadUserViewModel userViewModel = new ReadUserViewModel();
            

            blogViewModel = _mapper.Map(blog, blogViewModel);
            userViewModel = _mapper.Map(blog.User, userViewModel);
            commentViewModels = _mapper.Map(comments, commentViewModels);

            blogViewModel.CommentViewModels = commentViewModels;
            blogViewModel.UserViewModel = userViewModel;

            return View(blogViewModel);
        }


        [HttpGet]
        public PartialViewResult AddComment()
        {
            return PartialView();
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

            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
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