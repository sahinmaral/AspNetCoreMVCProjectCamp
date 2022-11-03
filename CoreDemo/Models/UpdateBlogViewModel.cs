using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Slugify;

namespace CoreDemo.Models
{
    public class UpdateBlogViewModel : BaseViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Slug
        {
            get
            {
                SlugHelper helper = new SlugHelper();
                return helper.GenerateSlug(Title);
            }

        }
        public string Content { get; set; }
        public IFormFile ThumbnailImage { get; set; }
        public IFormFile MainImage { get; set; }
        public string CreatedAt { get; set; }
        public bool Status { get; set; }

        public ReadUserViewModel WriterViewModel { get; set; }
        public ReadCategoryViewModel CategoryViewModel { get; set; }
        public List<ReadCommentViewModel> CommentViewModels { get; set; }
    }
}
