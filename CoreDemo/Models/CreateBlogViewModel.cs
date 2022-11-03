using Microsoft.AspNetCore.Http;
using Slugify;

namespace CoreDemo.Models
{
    public class CreateBlogViewModel : BaseViewModel
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Slug
        {
            get {
                SlugHelper helper = new SlugHelper();
                return helper.GenerateSlug(Title);
            }
            
        }
        public IFormFile ThumbnailImage { get; set; }
        public IFormFile MainImage { get; set; }
        public int CategoryId { get; set; }
    }
}
