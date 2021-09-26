using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class BlogManager:IBlogService
    {
        private readonly IBlogDal _blogDal;
        
        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }
        
        public List<Blog> GetAll(Expression<Func<Blog, bool>> filter = null)
        {
            return _blogDal.GetAll(filter);
        }

        public Blog Get(Expression<Func<Blog, bool>> filter = null)
        {
            return _blogDal.Get(filter);
        }

        public void Add(Blog entity)
        {
            _blogDal.Add(entity);
        }

        public void Delete(Blog entity)
        {
            _blogDal.Delete(entity);
        }

        public void Update(Blog entity)
        {
            _blogDal.Update(entity);
        }

        public List<Blog> GetAllByDetails(Expression<Func<Blog, bool>> filter = null)
        {
            return _blogDal.GetAllByDetails(filter);
        }
    }
}