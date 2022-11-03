namespace CoreDemo.Models
{
    public class CategoryAndBlogCountViewModel:BaseViewModel
    {
        public ReadCategoryViewModel CategoryViewModel { get; set; }

        public int BlogCount { get; set; }
    }
}
