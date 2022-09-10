using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Business.Abstract;
using CoreDemo.Models;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace CoreDemo.Areas.Writer.ViewComponents
{
    public class WriterStatisticsViewComponent : ViewComponent
    {
        private readonly IBlogService _blogService;
        private readonly IMapper _mapper;
        private readonly IStringLocalizer<WriterStatisticsViewComponent> _stringLocalizer;

        public WriterStatisticsViewComponent(IBlogService blogService,IMapper mapper, IStringLocalizer<WriterStatisticsViewComponent> stringLocalizer)
        {
            _blogService = blogService;
            _mapper = mapper;
            _stringLocalizer = stringLocalizer;
        }
        public IViewComponentResult Invoke(int currentWriterId)
        {
            List<Blog> writerBlogs = _blogService.GetAllWithDetails(x => x.UserId == currentWriterId);

            Dictionary<string, int> categoriesOfWritedBlogs = new Dictionary<string, int>();

            int lastOneWeekWritedBlogCount = 0;

            foreach (var writerBlog in writerBlogs)
            {
                if (!categoriesOfWritedBlogs.ContainsKey(writerBlog.Category.CategoryName))
                    categoriesOfWritedBlogs.Add(writerBlog.Category.CategoryName,1);
                
                else
                    categoriesOfWritedBlogs[writerBlog.Category.CategoryName] += 1;

                TimeSpan timeSpan = DateTime.Now.Subtract(writerBlog.BlogCreatedDate);

                if (timeSpan.Days == 7) lastOneWeekWritedBlogCount++;
                
            }

            string favouriteCategoryName = categoriesOfWritedBlogs.Count == 0 ? _stringLocalizer["None"] : categoriesOfWritedBlogs.First(x => x.Value == categoriesOfWritedBlogs.Values.Max()).Key;


            WriterStatisticsViewModel model = new WriterStatisticsViewModel
            {
                TotalWritedBlogCount = writerBlogs.Count,
                FavouriteCategoryName = favouriteCategoryName,
                LastOneWeekWritedBlogCount = lastOneWeekWritedBlogCount
            };


            return View(model);
        }
    }
}