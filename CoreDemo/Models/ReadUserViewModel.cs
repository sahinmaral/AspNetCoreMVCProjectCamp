using System;

namespace CoreDemo.Models
{
    public class ReadUserViewModel : BaseViewModel
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string NameSurname { get; set; }
        public string ImageUrl { get; set; }
        public string About { get; set; }
        public string MainRole { get; set; }
        public bool LockoutEnabled { get; set; }
        public DateTimeOffset LockoutEnd { get; set; }
    }
}