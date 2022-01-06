using System.Collections.Generic;

namespace CoreDemo.Models
{
    public class UpdateBlogViewModel
    {
        public int BlogId { get; set; }
        public string BlogTitle { get; set; }
        public string BlogContent { get; set; }
        public string BlogThumbnailImage { get; set; }
        public string BlogMainImage { get; set; }
        public string BlogCreateDate { get; set; }
        public bool BlogStatus { get; set; }

        public ReadWriterViewModel WriterViewModel { get; set; }
        public ReadCategoryViewModel CategoryViewModel { get; set; }
        public List<ReadCommentViewModel> CommentViewModels { get; set; }
    }
}
