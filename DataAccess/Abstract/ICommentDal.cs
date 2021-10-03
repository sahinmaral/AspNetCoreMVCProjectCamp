using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Core.DataAccess;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface ICommentDal:IEntityRepository<Comment>
    {
        public List<Comment> GetAllWithDetails(Expression<Func<Comment, bool>> filter = null);
    }   
}
