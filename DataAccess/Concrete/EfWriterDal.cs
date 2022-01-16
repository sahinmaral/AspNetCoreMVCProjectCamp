using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete
{
    public class EfWriterDal:EfEntityRepositoryBase<Writer,Context> , IWriterDal
    {
        
        public new void Add(Writer writer)
        {
            using Context context = new Context();

            var addedUserEntity = context.Entry(writer.User);
            addedUserEntity.State = EntityState.Added;
            context.SaveChanges();

            var addedEntity = context.Entry(writer);
            addedEntity.State = EntityState.Added;
            context.SaveChanges();
        }

        public new Writer Get(Expression<Func<Writer, bool>> filter)
        {
            using Context context = new Context();
            return context.Set<Writer>()
                .Include(x => x.User)
                .SingleOrDefault(filter);
        }

        public new List<Writer> GetAll(Expression<Func<Writer, bool>> filter = null)
        {
            using Context context = new Context();
            var writers = context.Writers
                .Include(x => x.User);

            return filter == null ? writers.ToList() : writers.Where(filter).ToList();
        }
    }
}