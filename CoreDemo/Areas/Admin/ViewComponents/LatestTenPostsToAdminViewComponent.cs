using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Business.Abstract;
using CoreDemo.Models;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Areas.Admin.ViewComponents
{
    public class LatestTenPostsToAdminViewComponent : ViewComponent
    {
        private readonly IBlogService _blogService;
        private readonly IMapper _mapper;
        public LatestTenPostsToAdminViewComponent(IBlogService blogService, IMapper mapper)
        {
            _blogService = blogService;
            _mapper = mapper;
        }

        public IViewComponentResult Invoke(int id)
        {
            List<ReadBlogViewModel> viewModels = new List<ReadBlogViewModel>();

            List<Blog> last5Blogs = _blogService.GetAllWithDetails(x=>x.UserId == id).TakeLast(10).ToList();

            viewModels = _mapper.Map(last5Blogs, viewModels);

            return View(viewModels);
        }
    }
}