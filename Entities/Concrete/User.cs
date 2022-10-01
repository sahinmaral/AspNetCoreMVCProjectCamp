using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Abstract;
using Microsoft.AspNetCore.Identity;

namespace Entities.Concrete
{
    public class User : IdentityUser<int> , IEntity
    {
        public string NameSurname { get; set; }
        public string ImageUrl { get; set; }
        public string UserAbout { get; set; }

    }
}
