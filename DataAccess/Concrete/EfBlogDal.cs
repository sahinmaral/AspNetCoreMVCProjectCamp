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
    public class EfBlogDal : EfEntityRepositoryBase<Blog, Context>, IBlogDal
    {
        public List<Blog> GetAllWithDetails(Expression<Func<Blog, bool>> filter = null)
        {
            using Context context = new Context();
            return filter == null
                ? context.Blogs.Include(x => x.Category)
                    .Include(x => x.Writer).Include(x=>x.BlogRatio).ToList()
                : context.Blogs.Include(x => x.Category)
                    .Include(x => x.Writer).Include(x => x.BlogRatio).Where(filter).ToList();
        }

        public Blog GetByBlogIdWithDetails(int blogId)
        {
            using Context context = new Context();
            return context.Blogs
                .Include(x => x.Category)
                .Include(x => x.Writer)
                .Include(x => x.BlogRatio)
                .SingleOrDefault(x => x.BlogId == blogId);
        }
    }
}