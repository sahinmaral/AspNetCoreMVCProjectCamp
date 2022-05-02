using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreDemo.Models;

namespace CoreDemo.Areas.Admin.Models
{
    public class UserRoleViewModel
    {
        public ReadUserViewModel UserViewModel { get; set; }
        public List<RoleViewModel> RoleViewModels { get; set; }
    }

    public class RoleViewModel
    {
        public string RoleName { get; set; }
        public bool IsInRole { get; set; }
    }
}
