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
        public List<Blog> GetAllByDetails(Expression<Func<Blog, bool>> filter = null)
        {
            using (Context context = new Context())
            {
                return filter == null
                    ? context.Blogs.Include(x => x.Category).ToList()
                    : context.Blogs.Include(x => x.Category).Where(filter).ToList();
            }
        }
    }
}