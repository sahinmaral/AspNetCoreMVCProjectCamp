namespace CoreDemo.Models
{
    public class ReadWriterViewModel
    {
        public int WriterId { get; set; }
        public string WriterAbout { get; set; }
        public string WriterImage { get; set; }
        public string WriterMail { get; set; }
        public ReadUserViewModel UserViewModel { get; set; }
    }
}
