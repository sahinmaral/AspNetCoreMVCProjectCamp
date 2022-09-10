using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace CoreDemo.Models
{
    public class UserSignUpViewModel
    {
        public string NameSurname { get; set; }

        public string Password { get; set; }

        public string ConfirmPassword { get; set; }
        public string Mail { get; set; }

        public string Username { get; set; }

        public IFormFile ProfileImage { get; set; }
        public string UserAbout { get; set; }
        public bool IsPoliciesAccepted { get; set; }

    }
}
