using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class AboutManager:IAboutService
    {
        private readonly IAboutDal _aboutDal;
        
        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }
        
        public List<About> GetAll(Expression<Func<About, bool>> filter = null)
        {
            return _aboutDal.GetAll(filter);
        }

        public About Get(Expression<Func<About, bool>> filter = null)
        {
            return _aboutDal.Get(filter);
        }

        public void Add(About entity)
        {
            _aboutDal.Add(entity);
        }

        public void Delete(About entity)
        {
            _aboutDal.Delete(entity);
        }

        public void Update(About entity)
        {
            _aboutDal.Update(entity);
        }
    }
}