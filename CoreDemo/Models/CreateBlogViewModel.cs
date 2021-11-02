namespace CoreDemo.Models
{
    public class CreateBlogViewModel
    {
        public string BlogTitle { get; set; }
        public string BlogContent { get; set; }
        public string BlogThumbnailImage { get; set; }
        public string BlogMainImage { get; set; }
        public int CategoryId { get; set; }
    }
}
