using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Business.Abstract;
using CoreDemo.Models;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace CoreDemo.Areas.Admin.ViewComponents
{
    public class AdminStatisticsViewComponent : ViewComponent
    {
        private readonly IBlogService _blogService;
        private readonly IMapper _mapper;
        private readonly IStringLocalizer<AdminStatisticsViewComponent> _stringLocalizer;

        public AdminStatisticsViewComponent(IBlogService blogService,IMapper mapper, IStringLocalizer<AdminStatisticsViewComponent> stringLocalizer)
        {
            _blogService = blogService;
            _mapper = mapper;
            _stringLocalizer = stringLocalizer;
        }
        public IViewComponentResult Invoke(int id)
        {
            List<Blog> writerBlogs = _blogService.GetAllWithDetails(x => x.UserId == id);

            Dictionary<string, int> categoriesOfWritedBlogs = new Dictionary<string, int>();

            int lastOneWeekWritedBlogCount = 0;

            foreach (var writerBlog in writerBlogs)
            {
                if (!categoriesOfWritedBlogs.ContainsKey(writerBlog.Category.Name))
                    categoriesOfWritedBlogs.Add(writerBlog.Category.Name,1);
                
                else
                    categoriesOfWritedBlogs[writerBlog.Category.Name] += 1;

                TimeSpan timeSpan = DateTime.Now.Subtract(writerBlog.CreatedAt);

                if (timeSpan.Days == 7) lastOneWeekWritedBlogCount++;
                
            }

            string favouriteCategoryName = categoriesOfWritedBlogs.Count == 0 ? _stringLocalizer["None"] : categoriesOfWritedBlogs.First(x => x.Value == categoriesOfWritedBlogs.Values.Max()).Key;


            HomepageStatisticsViewModel model = new HomepageStatisticsViewModel
            {
                TotalWrittenBlogCount = writerBlogs.Count,
                FavouriteCategoryName = favouriteCategoryName,
                LastOneWeekWritedBlogCount = lastOneWeekWritedBlogCount
            };


            return View(model);
        }
    }
}