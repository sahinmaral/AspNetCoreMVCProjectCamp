using Microsoft.AspNetCore.Http;

namespace CoreDemo.Models
{
    public class UserSignUpViewModel : BaseViewModel
    {
        public string NameSurname { get; set; }

        public string Password { get; set; }

        public string ConfirmPassword { get; set; }
        public string Email { get; set; }

        public string Username { get; set; }

        public IFormFile ProfileImage { get; set; }
        public string About { get; set; }
        public bool IsPoliciesAccepted { get; set; }

    }
}
