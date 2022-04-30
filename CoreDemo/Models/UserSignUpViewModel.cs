using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace CoreDemo.Models
{
    public class UserSignUpViewModel
    {
        [Display(Name = "Ad Soyad")]
        [Required(ErrorMessage = "Lutfen adinizi ve soyadinizi giriniz")]
        public string NameSurname { get; set; }

        [Display(Name = "Sifre")]
        [Required(ErrorMessage = "Lutfen sifrenizi giriniz")]
        public string Password { get; set; }

        [Display(Name = "Sifre Tekrar")]
        [Compare("Password",ErrorMessage = "Sifreler uyusmuyor")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Mail Adresi")]
        [Required(ErrorMessage = "Lutfen mailinizi giriniz")]
        public string Mail { get; set; }

        [Display(Name = "Kullanici adi")]
        [Required(ErrorMessage = "Lutfen kullanici adinizi giriniz")]
        public string Username { get; set; }

        public IFormFile ProfileImage { get; set; }
        public string UserAbout { get; set; }

        public bool IsPoliciesAccepted { get; set; }

    }
}
