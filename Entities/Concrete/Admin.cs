using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Abstract;
using Core.Entities.Concrete;

namespace Entities.Concrete
{
    public class Admin : IEntity
    {
        public int AdminId { get; set; }
        public User User { get; set; }
    }
}
