using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Concrete;

namespace CoreDemo.Models
{
    public class ReadBlogViewModel : BaseViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Slug { get; set; }
        public string Content { get; set; }
        public string ThumbnailImage { get; set; }
        public string MainImage { get; set; }
        public string CreatedAt { get; set; }
        public bool Status { get; set; }

        public ReadUserViewModel UserViewModel { get; set; }
        public ReadCategoryViewModel CategoryViewModel { get; set; }
        public List<ReadCommentViewModel> CommentViewModels { get; set; }
    }
}
