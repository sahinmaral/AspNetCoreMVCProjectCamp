using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Business.Abstract;
using CoreDemo.Models;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Areas.Writer.ViewComponents
{
    public class LatestTenPostsToWriterViewComponent : ViewComponent
    {
        private readonly IBlogService _blogService;
        private readonly IMapper _mapper;
        public LatestTenPostsToWriterViewComponent(IBlogService blogService, IMapper mapper)
        {
            _blogService = blogService;
            _mapper = mapper;
        }

        public IViewComponentResult Invoke(string username)
        {
            List<ReadBlogViewModel> viewModels = new List<ReadBlogViewModel>();

            List<Blog> last10Blogs = _blogService.GetAllWithDetails(x => x.User.UserName == username).OrderByDescending(x => x.CreatedAt).Take(10).ToList();

            viewModels = _mapper.Map(last10Blogs, viewModels);

            return View(viewModels);
        }
    }
}