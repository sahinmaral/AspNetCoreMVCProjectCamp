using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Core.DataAccess;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IBlogDal:IEntityRepository<Blog>
    {
        public List<Blog> GetAllByDetails(Expression<Func<Blog, bool>> filter = null);
    }   
}
