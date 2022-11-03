using Microsoft.AspNetCore.Http;

namespace CoreDemo.Models
{
    public class UserImageViewModel : BaseViewModel
    {
        public IFormFile ProfileImage { get; set; }
    }
}
