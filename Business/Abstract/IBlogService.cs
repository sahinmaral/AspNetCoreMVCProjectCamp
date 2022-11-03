using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IBlogService:IGenericRepositoryService<Blog>
    {
        List<Blog> GetAllWithDetails(Expression<Func<Blog, bool>> filter = null);
        Blog GetBySlugWithDetails(string slug);
        Blog GetByIdWithDetails(int id);
    }
}