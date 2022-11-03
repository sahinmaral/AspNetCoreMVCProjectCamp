using System;

namespace CoreDemo.Areas.Admin.Models
{
    public class RespondContactedUserViewModel
    {
        public int Id { get; set; }
        public string NameSurname { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public DateTime SentAt { get; set; }
    }
}
