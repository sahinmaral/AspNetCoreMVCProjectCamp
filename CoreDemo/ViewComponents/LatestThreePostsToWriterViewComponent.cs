using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Business.Abstract;
using CoreDemo.Models;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents
{
    public class LatestThreePostsToWriterViewComponent : ViewComponent
    {
        private readonly IBlogService _blogService;
        private readonly IMapper _mapper;
        public LatestThreePostsToWriterViewComponent(IBlogService blogService, IMapper mapper)
        {
            _blogService = blogService;
            _mapper = mapper;
        }

        public IViewComponentResult Invoke(int writerId,int currentBlogId)
        {
            List<ReadBlogViewModel> viewModels = new List<ReadBlogViewModel>();

            List<Blog> last3Blogs = _blogService.GetAllWithDetails(x=>x.UserId == writerId).TakeLast(3).ToList();

            last3Blogs.Remove(last3Blogs.Single(x=>x.BlogId == currentBlogId));

            viewModels = _mapper.Map(last3Blogs, viewModels);

            return View(viewModels);
        }
    }
}