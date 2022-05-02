using CoreDemo.Models;

namespace CoreDemo.Areas.Admin.Models
{
    public class UpdateCommentViewModel
    {
        public int CommentId { get; set; }
        public string CommentAbout { get; set; }
        public string BlogTitle { get; set; }
        public string BlogId { get; set; }
    }
}