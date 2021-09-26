using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IBlogService:IGenericRepositoryService<Blog>
    {
        List<Blog> GetAllByDetails(Expression<Func<Blog, bool>> filter = null);
    }
}