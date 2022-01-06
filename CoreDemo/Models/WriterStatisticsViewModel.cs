using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Models
{
    public class WriterStatisticsViewModel
    {
        public int TotalWritedBlogCount { get; set; }
        public string FavouriteCategoryName { get; set; }
        public int LastOneWeekWritedBlogCount { get; set; }
    }
}
