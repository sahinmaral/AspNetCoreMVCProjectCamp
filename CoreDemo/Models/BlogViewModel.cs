using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Concrete;

namespace CoreDemo.Models
{
    public class BlogViewModel
    {
        public int BlogId { get; set; }
        public string BlogTitle { get; set; }
        public string BlogContent { get; set; }
        public string BlogThumbnailImage { get; set; }
        public string BlogMainImage { get; set; }
        public string BlogCreateDate { get; set; }
        public bool BlogStatus { get; set; }


        public CategoryViewModel CategoryViewModel { get; set; }
        public List<CommentViewModel> CommentViewModels { get; set; }
    }
}
