using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreDemo.Models;

namespace CoreDemo.Areas.Admin.Models
{
    public class AdminSideBarViewModel
    {
        public ReadUserViewModel ReadUserViewModel { get; set; }
        public MessageTypeCountViewModel MessageTypeCountViewModel { get; set; }
    }
}
