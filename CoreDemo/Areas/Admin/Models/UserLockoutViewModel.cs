using CoreDemo.Models;
using System;

namespace CoreDemo.Areas.Admin.Models
{
    public class UserLockoutViewModel
    {
        public ReadUserViewModel UserViewModel { get; set; }
        public DateTimeOffset LockoutEnd { get; set; }
    }
}
