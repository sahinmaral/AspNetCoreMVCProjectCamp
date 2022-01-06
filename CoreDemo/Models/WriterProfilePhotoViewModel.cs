using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace CoreDemo.Models
{
    public class WriterProfilePhotoViewModel
    {
        public IFormFile ProfilePhoto { get; set; }
    }
}
