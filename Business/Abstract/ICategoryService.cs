using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        public List<Category> GetAll(Expression<Func<Category,bool>> filter = null);
        public Category Get(Expression<Func<Category,bool>> filter = null);
        public void Add(Category category);
        public void Delete(Category category);
        public void Update(Category category);

    }
}