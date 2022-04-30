using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace CoreDemo.Models
{
    public class UpdateBlogViewModel
    {
        public int BlogId { get; set; }
        public string BlogTitle { get; set; }
        public string BlogContent { get; set; }
        public IFormFile BlogThumbnailImage { get; set; }
        public IFormFile BlogMainImage { get; set; }
        public string BlogCreateDate { get; set; }
        public bool BlogStatus { get; set; }

        public ReadUserViewModel WriterViewModel { get; set; }
        public ReadCategoryViewModel CategoryViewModel { get; set; }
        public List<ReadCommentViewModel> CommentViewModels { get; set; }
    }
}
