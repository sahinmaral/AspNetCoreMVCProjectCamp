using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Abstract;
using Microsoft.AspNetCore.Identity;

namespace Entities.Concrete
{
    public class Role : IdentityRole<int> , IEntity
    {
    }
}
