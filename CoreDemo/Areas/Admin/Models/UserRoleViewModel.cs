using System.Collections.Generic;
using CoreDemo.Models;

namespace CoreDemo.Areas.Admin.Models
{
    public class UserRoleViewModel
    {
        public ReadUserViewModel UserViewModel { get; set; }
        public RoleViewModel RoleViewModel { get; set; }
    }
}