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
                ? context.Blogs
                    .Include(x => x.Category)
                    .Include(x => x.User)
                    .Include(x=>x.BlogRatio)
                    .Include(x=>x.Comments)
                    .ToList()
                : context.Blogs
                    .Include(x => x.Category)
                    .Include(x => x.User)
                    .Include(x => x.BlogRatio)
                    .Include(x => x.Comments)
                    .Where(filter).ToList();
        }

        public Blog GetByIdWithDetails(int id)
        {
            using Context context = new Context();
            return context.Blogs
                .Include(x => x.Category)
                .Include(x => x.User)
                .Include(x => x.BlogRatio)
                .Include(x => x.Comments)
                .SingleOrDefault(x => x.Id == id);
        }

        public Blog GetBySlugWithDetails(string slug)
        {
            using Context context = new Context();
            return context.Blogs
                .Include(x => x.Category)
                .Include(x => x.User)
                .Include(x => x.BlogRatio)
                .Include(x => x.Comments)
                .SingleOrDefault(x => x.Slug == slug);
        }
    }
}