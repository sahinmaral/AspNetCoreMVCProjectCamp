using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Business.Abstract;
using CoreDemo.Models;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents
{
    public class LatestPostsToWriterViewComponent : ViewComponent
    {
        private readonly IBlogService _blogService;
        private readonly IMapper _mapper;
        public LatestPostsToWriterViewComponent(IBlogService blogService, IMapper mapper)
        {
            _blogService = blogService;
            _mapper = mapper;
        }

        public IViewComponentResult Invoke(int writerId,int currentBlogId)
        {
            List<ReadBlogViewModel> viewModels = new List<ReadBlogViewModel>();

            List<Blog> last3Blogs = _blogService.GetAllWithDetails(x=>x.UserId == writerId).OrderByDescending(x=>x.CreatedAt).Take(3).ToList();

            last3Blogs.Remove(last3Blogs.Single(x=>x.Id == currentBlogId));

            viewModels = _mapper.Map(last3Blogs, viewModels);

            return View(viewModels);
        }
    }
}