using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Business.Abstract;
using CoreDemo.Models;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents
{
    public class LatestPostsViewComponent : ViewComponent
    {
        private readonly IBlogService _blogService;
        private readonly IMapper _mapper;
        public LatestPostsViewComponent(IBlogService blogService, IMapper mapper)
        {
            _blogService = blogService;
            _mapper = mapper;
        }

        public IViewComponentResult Invoke()
        {
            List<ReadBlogViewModel> viewModels = new List<ReadBlogViewModel>();

            List<Blog> last3Blogs = _blogService.GetAll().TakeLast(3).ToList();

            viewModels = _mapper.Map(last3Blogs, viewModels);

            return View(viewModels);
        }
    }
}