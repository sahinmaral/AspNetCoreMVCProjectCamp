using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Concrete;

namespace CoreDemo.Models
{
    public class ReadBlogViewModel
    {
        public int BlogId { get; set; }
        public string BlogTitle { get; set; }
        public string BlogContent { get; set; }
        public string BlogThumbnailImage { get; set; }
        public string BlogMainImage { get; set; }
        public string BlogCreateDate { get; set; }
        public bool BlogStatus { get; set; }

        public ReadUserViewModel UserViewModel { get; set; }
        public ReadCategoryViewModel CategoryViewModel { get; set; }
        public List<ReadCommentViewModel> CommentViewModels { get; set; }
    }
}
