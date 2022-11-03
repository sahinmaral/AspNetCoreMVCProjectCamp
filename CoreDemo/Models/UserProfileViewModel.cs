using Entities.Concrete;
using System;

namespace CoreDemo.Models
{
    public class UserProfileViewModel : BaseViewModel
    {
        public ReadUserViewModel UserViewModel { get; set; }
        public string Role { get; set; }
        public int BlogWrittenCount { get; set; }
        public string FavouriteCategoryName { get; set; }
        public int LikedBlogCount { get; set; }
        public int DislikedBlogCount { get; set; }
        public int CommentWrittenCount { get; set; }
    }
}
