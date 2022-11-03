using System;

namespace CoreDemo.Models
{
    public class ReadContactViewModel : BaseViewModel
    {
        public int Id { get; set; }
        public string NameSurname { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public bool IsOpened { get; set; }
        public bool IsAnswered { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
