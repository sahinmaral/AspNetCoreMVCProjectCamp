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
    public class EfAdminDal:EfEntityRepositoryBase<Admin, Context> , IAdminDal
    {
        public new Admin Get(Expression<Func<Admin, bool>> filter)
        {
            using Context context = new Context();
            return context.Set<Admin>()
                .Include(x => x.User)
                .SingleOrDefault(filter);
        }

        public new List<Admin> GetAll(Expression<Func<Admin, bool>> filter = null)
        {
            using Context context = new Context();
            var writers = context.Admins
                .Include(x => x.User);

            return filter == null ? writers.ToList() : writers.Where(filter).ToList();
        }
    }
}