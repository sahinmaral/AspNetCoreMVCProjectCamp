using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Business.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class WriterManager:IWriterService
    {
        private readonly IWriterService _writerService;
        
        public WriterManager(IWriterService writerService)
        {
            _writerService = writerService;
        }
        
        public List<Writer> GetAll(Expression<Func<Writer, bool>> filter = null)
        {
            return _writerService.GetAll(filter);
        }

        public Writer Get(Expression<Func<Writer, bool>> filter = null)
        {
            return _writerService.Get(filter);
        }

        public void Add(Writer entity)
        {
            _writerService.Add(entity);
        }

        public void Delete(Writer entity)
        {
            _writerService.Delete(entity);
        }

        public void Update(Writer entity)
        {
            _writerService.Update(entity);
        }
    }
}