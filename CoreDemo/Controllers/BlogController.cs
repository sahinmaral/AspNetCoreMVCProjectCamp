using AutoMapper;
using Business.Abstract;
using Core.Helper.Toastr;
using Core.Helper.Toastr.OptionEnums;
using CoreDemo.Logic;
using CoreDemo.Models;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Extensions.Localization;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    [AllowAnonymous]
    public class BlogController : Controller
    {
        private readonly IBlogService _blogService;
        private readonly ICategoryService _categoryService;
        private readonly ICommentService _commentService;
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;
        private readonly IStringLocalizer<BlogController> _localizer;

        public BlogController(IBlogService blogService, ICommentService commentService, IMapper mapper, UserManager<User> userManager, IStringLocalizer<BlogController> localizer, ICategoryService categoryService)
        {
            _blogService = blogService;
            _commentService = commentService;
            _mapper = mapper;
            _userManager = userManager;
            _localizer = localizer;
            _categoryService = categoryService;
        }


        public IActionResult GetAll()
        {
            List<Blog> blogs = _blogService.GetAllWithDetails();

            List<ReadBlogViewModel> blogViewModels = new List<ReadBlogViewModel>();

            blogViewModels = _mapper.Map(blogs, blogViewModels);

            return View(blogViewModels);
        }

        [Route("/Blog/GetBySlug/{slug}")]
        public IActionResult GetBySlug(string slug)
        {

            Blog blog = _blogService.GetBySlugWithDetails(slug);

            ReadBlogViewModel blogViewModel = new ReadBlogViewModel();
            blogViewModel = _mapper.Map(blog, blogViewModel);

            ReadUserViewModel userViewModel = _mapper.Map(blog.User, new ReadUserViewModel());
            List<ReadCommentViewModel> commentViewModels = _mapper.Map(blog.Comments, new List<ReadCommentViewModel>());

            blogViewModel.CommentViewModels = commentViewModels;
            blogViewModel.UserViewModel = userViewModel;

            return View(blogViewModel);
        }

        [Route("/Blog/GetAllByCategorySlug/{slug}")]
        public IActionResult GetAllByCategorySlug(string slug)
        {
            List<Blog> blogs = _blogService.GetAllWithDetails(x=>x.Category.Name == slug);

            TempData["CategoryName"] = _categoryService.Get(x => x.Slug == slug).Name;

            List<ReadBlogViewModel> blogViewModels = _mapper.Map(blogs, new List<ReadBlogViewModel>());

            return View(blogViewModels);
        }

        [Route("/Blog/GetAllByUsername/{username}")]
        public IActionResult GetAllByUsername(string username)
        {

            List<Blog> blogs = _blogService.GetAllWithDetails(x => x.User.UserName == username);

            List<ReadBlogViewModel> blogViewModels = _mapper.Map(blogs, new List<ReadBlogViewModel>());

            ViewData["Username"] = username;

            return View(blogViewModels);
        }


        [HttpPost]
        public async Task<IActionResult> AddComment(CreateCommentViewModel viewModel)
        {

            Dictionary<string, bool> logics = new Dictionary<string, bool>();
            logics.Add(_localizer["MustLoginToDropComment"], User.Identity.Name != null);

            string failedRule = LogicRules.Run(logics);

            if (!string.IsNullOrEmpty(failedRule))
            {
                TempData["Message"] = ToastrNotification.Show(failedRule, position: Position.BottomRight,
                type: ToastType.error);

                return RedirectToRoute(new
                {
                    controller = nameof(BlogController).Replace("Controller", ""),
                    action = nameof(GetBySlug),
                    slug = viewModel.BlogSlug
                });
            }

            logics.Clear();

            if (!ModelState.IsValid)
            {
                var modelErrors = ModelState.Values.SelectMany(x => x.Errors);

                var errors = "";

                foreach (var error in modelErrors)
                {
                    errors += error.ErrorMessage;
                    errors += "<br/>";
                }

                TempData["Message"] = ToastrNotification.Show(errors, position: Position.BottomRight,
                    type: ToastType.error);

                return RedirectToRoute(new
                {
                    controller = nameof(BlogController).Replace("Controller", ""),
                    action = nameof(GetBySlug),
                    slug = viewModel.BlogSlug
                });
            }

            User user = await _userManager.FindByNameAsync(User.Identity.Name);
            viewModel.UserId = user.Id;

            var test = _commentService.GetAll().Count() == 0;
            var test2 = _commentService.GetAll();

            logics.Add(_localizer["CannotDropCommentYourBlog"], _blogService.GetBySlugWithDetails(viewModel.BlogSlug).UserId != user.Id);
            logics.Add(_localizer["OneCommentPerUser"], _commentService.GetAll().Count() == 0 || !_commentService.GetAllWithDetails().Any(x => x.Blog.Slug == viewModel.BlogSlug && x.UserId == user.Id));

            failedRule = LogicRules.Run(logics);

            if (!string.IsNullOrEmpty(failedRule))
            {
                TempData["Message"] = ToastrNotification.Show(failedRule, position: Position.BottomRight,
                type: ToastType.error);

                return RedirectToRoute(new
                {
                    controller = nameof(BlogController).Replace("Controller", ""),
                    action = nameof(GetBySlug),
                    slug = viewModel.BlogSlug
                });
            }

            Comment addedComment = _mapper.Map(viewModel, new Comment());
            addedComment.BlogId = _blogService.Get(x=>x.Slug == viewModel.BlogSlug).Id;
            _commentService.Add(addedComment);

            TempData["Message"] = ToastrNotification.Show(_localizer["CommentSuccessfullySent"], position: Position.BottomRight,
                type: ToastType.success);

            return RedirectToRoute(new
            {
                controller = nameof(BlogController).Replace("Controller", ""),
                action = nameof(GetBySlug),
                slug = viewModel.BlogSlug
            });
        }
    }
}