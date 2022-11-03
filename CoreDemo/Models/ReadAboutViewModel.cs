namespace CoreDemo.Models
{
    public class ReadAboutViewModel : BaseViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Detail { get; set; }
        public string ImageUrl { get; set; }
        public string MapLocation { get; set; }
        public bool Status { get; set; }
    }
}
