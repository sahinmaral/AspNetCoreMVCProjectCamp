using AutoMapper;
using Business.Abstract;
using CoreDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace CoreDemo.ViewComponents
{
    public class TopFavouriteCategoriesViewComponent:ViewComponent
    {
        private readonly ICategoryService _categoryService;
        private readonly IBlogService _blogService;
        private readonly IMapper _mapper;

        public TopFavouriteCategoriesViewComponent(ICategoryService categoryService, IBlogService blogService, IMapper mapper)
        {
            _categoryService = categoryService;
            _blogService = blogService;
            _mapper = mapper;
        }
        public IViewComponentResult Invoke()
        {
            List<CategoryAndBlogCountViewModel> viewModels = new List<CategoryAndBlogCountViewModel>();

            var groupedEntities = _blogService.GetAllWithDetails(x=>x.Status).GroupBy(x => x.Category).Select(entity => new
            {
                Category = entity.Key,
                BlogCount = entity.Count()
            }).OrderByDescending(x => x.BlogCount).Take(5).ToList();

            groupedEntities.ForEach(entity =>
            {
                viewModels.Add(new CategoryAndBlogCountViewModel()
                {
                    CategoryViewModel = _mapper.Map(entity.Category,new ReadCategoryViewModel()),
                    BlogCount = entity.BlogCount
                });
            });


            return View(viewModels);
        }
    }
}
