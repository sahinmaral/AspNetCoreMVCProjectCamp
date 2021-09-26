using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Business.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class AboutManager:IAboutService
    {
        private readonly IAboutService _aboutService;
        
        public AboutManager(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }
        
        public List<About> GetAll(Expression<Func<About, bool>> filter = null)
        {
            return _aboutService.GetAll(filter);
        }

        public About Get(Expression<Func<About, bool>> filter = null)
        {
            return _aboutService.Get(filter);
        }

        public void Add(About entity)
        {
            _aboutService.Add(entity);
        }

        public void Delete(About entity)
        {
            _aboutService.Delete(entity);
        }

        public void Update(About entity)
        {
            _aboutService.Update(entity);
        }
    }
}