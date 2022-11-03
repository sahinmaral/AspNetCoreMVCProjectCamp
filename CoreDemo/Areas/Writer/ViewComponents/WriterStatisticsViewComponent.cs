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
        private readonly IStringLocalizer<WriterStatisticsViewComponent> _stringLocalizer;

        public WriterStatisticsViewComponent(IBlogService blogService,IStringLocalizer<WriterStatisticsViewComponent> stringLocalizer)
        {
            _blogService = blogService;
            _stringLocalizer = stringLocalizer;
        }
        public IViewComponentResult Invoke(string username)
        {
            List<Blog> writerBlogs = _blogService.GetAllWithDetails(x => x.User.UserName == username);

            Dictionary<string, int> categoriesOfWritedBlogs = new Dictionary<string, int>();

            int lastOneWeekWritedBlogCount = 0;

            foreach (var writerBlog in writerBlogs)
            {
                if (!categoriesOfWritedBlogs.ContainsKey(writerBlog.Category.Name))
                    categoriesOfWritedBlogs.Add(writerBlog.Category.Name, 1);
                
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