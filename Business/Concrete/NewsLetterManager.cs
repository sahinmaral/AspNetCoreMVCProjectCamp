using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class NewsLetterManager:INewsLetterService
    {
        private readonly INewsLetterDal _newsLetterDal;
        
        public NewsLetterManager(INewsLetterDal newsLetterDal)
        {
            _newsLetterDal = newsLetterDal;
        }
        
        public List<NewsLetter> GetAll(Expression<Func<NewsLetter, bool>> filter = null)
        {
            return _newsLetterDal.GetAll(filter);
        }

        public NewsLetter Get(Expression<Func<NewsLetter, bool>> filter = null)
        {
            return _newsLetterDal.Get(filter);
        }

        public void Add(NewsLetter entity)
        {
            _newsLetterDal.Add(entity);
        }

        public void Delete(NewsLetter entity)
        {
            _newsLetterDal.Delete(entity);
        }

        public void Update(NewsLetter entity)
        {
            _newsLetterDal.Update(entity);
        }
    }
}