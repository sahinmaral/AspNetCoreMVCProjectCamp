using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface IGenericRepositoryService<T>
    {
        public List<T> GetAll(Expression<Func<T,bool>> filter = null);
        public T Get(Expression<Func<T,bool>> filter = null);
        public void Add(T entity);
        public void Delete(T entity);
        public void Update(T entity);
    }
}