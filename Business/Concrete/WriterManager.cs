using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class WriterManager:IWriterService
    {
        private readonly IWriterDal _writerDal;
        
        public WriterManager(IWriterDal writerDal)
        {
            _writerDal = writerDal;
        }
        
        public List<Writer> GetAll(Expression<Func<Writer, bool>> filter = null)
        {
            return _writerDal.GetAll(filter);
        }

        public Writer Get(Expression<Func<Writer, bool>> filter = null)
        {
            return _writerDal.Get(filter);
        }

        public void Add(Writer entity)
        {
            _writerDal.Add(entity);
        }

        public void Delete(Writer entity)
        {
            _writerDal.Delete(entity);
        }

        public void Update(Writer entity)
        {
            _writerDal.Update(entity);
        }

    }
}