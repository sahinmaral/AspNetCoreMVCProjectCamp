namespace CoreDemo.Models
{
    public class ReadCommentViewModel
    {
        public int CommentId { get; set; }
        public string CommentAbout { get; set; }
        public string CommentCreatedDate { get; set; }
        public bool CommentStatus { get; set; }
        public bool LikeOrDislikeStatus { get; set; }

        public ReadBlogViewModel BlogViewModel { get; set; }
        public ReadUserViewModel UserViewModel { get; set; }
    }
}
