using System;

namespace CoreDemo.Models
{
    public class CreateCommentViewModel:BaseViewModel
    {
        public CreateCommentViewModel()
        {
            CreatedAt = DateTime.Now;
            Status = true;
        }
        public string Detail { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool Status { get; set; }
        public bool LikeOrDislikeStatus { get; set; }
        public string BlogSlug { get; set; }
        public int UserId { get; set; }
    }
}
