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
    public class EfCommentDal : EfEntityRepositoryBase<Comment, Context>, ICommentDal
    {
        public List<Comment> GetAllWithDetails(Expression<Func<Comment, bool>> filter = null)
        {
            using Context context = new Context();
            return filter == null
                ? context.Comments.Include(x => x.Writer)
                    .Include(x=>x.Blog)
                    .Include(x=>x.Writer.User)
                    .ToList()
                : context.Comments.Include(x => x.Writer)
                    .Include(x => x.Blog)
                    .Include(x => x.Writer.User)
                    .Where(filter).ToList();
        }
    }

}