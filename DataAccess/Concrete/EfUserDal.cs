using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;

using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete
{
    public class EfUserDal:EfEntityRepositoryBase<User, Context> , IUserDal
    {
        
    }
}