using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Models
{
    public class ReadStatisticsViewModel
    {
        public int TotalBlogCount { get; set; }
        public int NewContactCount { get; set; }
        public int NewMessageCount { get; set; }
        public int TotalCommentCount { get; set; }
        public ReadBlogViewModel LastBlog { get; set; }
    }
}
