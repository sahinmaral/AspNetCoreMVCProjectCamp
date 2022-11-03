namespace CoreDemo.Models
{
    public class ReadCommentViewModel
    {
        public int Id { get; set; }
        public string Detail { get; set; }
        public string CreatedAt { get; set; }
        public bool Status { get; set; }
        public bool LikeOrDislikeStatus { get; set; }

        public ReadBlogViewModel BlogViewModel { get; set; }
        public ReadUserViewModel UserViewModel { get; set; }
    }
}
