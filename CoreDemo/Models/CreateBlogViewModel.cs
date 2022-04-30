using Microsoft.AspNetCore.Http;

namespace CoreDemo.Models
{
    public class CreateBlogViewModel
    {
        public string BlogTitle { get; set; }
        public string BlogContent { get; set; }
        public IFormFile BlogThumbnailImage { get; set; }
        public IFormFile BlogMainImage { get; set; }
        public int CategoryId { get; set; }
    }
}
