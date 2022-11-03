using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Core.DataAccess;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IBlogDal:IEntityRepository<Blog>
    {
        public List<Blog> GetAllWithDetails(Expression<Func<Blog, bool>> filter = null);
        public Blog GetBySlugWithDetails(string slug);
        public Blog GetByIdWithDetails(int id);
    }   
}
