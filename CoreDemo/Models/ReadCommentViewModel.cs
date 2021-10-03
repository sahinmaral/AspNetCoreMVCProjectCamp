namespace CoreDemo.Models
{
    public class ReadCommentViewModel
    {
        public int CommentId { get; set; }
        public string CommentAbout { get; set; }
        public string CommentCreateDate { get; set; }
        public bool CommentStatus { get; set; }
        public int BlogId { get; set; }

        public ReadWriterViewModel WriterViewModel { get; set; }
    }
}
