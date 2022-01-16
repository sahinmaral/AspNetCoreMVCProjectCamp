using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;

namespace CoreDemo.Models
{
    public class RegisterWriterViewModel
    {
        public string WriterName { get; set; }
        public string WriterUsername { get; set; }
        public string WriterAbout { get; set; }
        public IFormFile WriterImage { get; set; }
        public string WriterMail { get; set; }
        public string WriterPassword { get; set; }
        public string WriterPasswordRepeat { get; set; }
    }
}
