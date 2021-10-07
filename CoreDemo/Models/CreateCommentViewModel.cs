using System;

namespace CoreDemo.Models
{
    public class CreateCommentViewModel
    {
        public CreateCommentViewModel()
        {
            CommentCreateDate = DateTime.Now;
            CommentStatus = true;
        }
        public string CommentAbout { get; set; }
        public DateTime CommentCreateDate { get; set; }
        public bool CommentStatus { get; set; }
        public int BlogId { get; set; }
        public int WriterId { get; set; }
    }
}
