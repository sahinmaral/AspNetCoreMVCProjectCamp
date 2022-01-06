using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Business.Abstract;
using CoreDemo.Models;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents
{
    public class WriterStatisticsViewComponent : ViewComponent
    {
        private readonly IBlogService _blogService;
        private readonly IMapper _mapper;


        public WriterStatisticsViewComponent(IBlogService blogService,IMapper mapper)
        {
            _blogService = blogService;
            _mapper = mapper;
        }
        public IViewComponentResult Invoke(int currentWriterId)
        {
            List<Blog> writerBlogs = _blogService.GetAllWithDetails(x => x.WriterId == currentWriterId);

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

            string favouriteCategoryName = categoriesOfWritedBlogs.First(x => x.Value == categoriesOfWritedBlogs.Values.Max()).Key;


            WriterStatisticsViewModel model = new WriterStatisticsViewModel
            {
                TotalWritedBlogCount = writerBlogs.Count,
                FavouriteCategoryName = favouriteCategoryName,
                LastOneWeekWritedBlogCount = 0
            };


            return View(model);
        }
    }
}