using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICommentService:IGenericRepositoryService<Comment>
    {
        public List<Comment> GetAllWithDetails(Expression<Func<Comment, bool>> filter = null);
    }
}