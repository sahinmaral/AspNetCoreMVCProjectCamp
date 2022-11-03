namespace CoreDemo.Models
{
    public class HomepageStatisticsViewModel : BaseViewModel
    {
        public int TotalWrittenBlogCount { get; set; }
        public string FavouriteCategoryName { get; set; }
        public int LastOneWeekWritedBlogCount { get; set; }
    }
}
