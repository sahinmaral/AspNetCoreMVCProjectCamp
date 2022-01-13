using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class MessageManager: IMessageService
    {
        private readonly IMessageDal _messageDal;
        
        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }
        
        public List<Message> GetAll(Expression<Func<Message, bool>> filter = null)
        {
            return _messageDal.GetAll(filter);
        }

        public Message Get(Expression<Func<Message, bool>> filter = null)
        {
            return _messageDal.Get(filter);
        }

        public void Add(Message entity)
        {
            _messageDal.Add(entity);
        }

        public void Delete(Message entity)
        {
            _messageDal.Delete(entity);
        }

        public void Update(Message entity)
        {
            _messageDal.Update(entity);
        }

    }
}