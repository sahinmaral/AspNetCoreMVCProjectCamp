using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Business.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class BlogManager:IBlogService
    {
        private readonly IBlogService _blogService;
        
        public BlogManager(IBlogService blogService)
        {
            _blogService = blogService;
        }
        
        public List<Blog> GetAll(Expression<Func<Blog, bool>> filter = null)
        {
            return _blogService.GetAll(filter);
        }

        public Blog Get(Expression<Func<Blog, bool>> filter = null)
        {
            return _blogService.Get(filter);
        }

        public void Add(Blog entity)
        {
            _blogService.Add(entity);
        }

        public void Delete(Blog entity)
        {
            _blogService.Delete(entity);
        }

        public void Update(Blog entity)
        {
            _blogService.Update(entity);
        }
    }
}