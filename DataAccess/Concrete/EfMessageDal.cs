using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete
{
    public class EfMessageDal:EfEntityRepositoryBase<Message,Context> , IMessageDal
    {
        public new List<Message> GetAll(Expression<Func<Message, bool>> filter = null)
        {
            using Context context = new Context();
            var messages = context.Messages
                .Include(x => x.Sender)
                .Include(x => x.Receiver);

            return filter == null ? messages.ToList() : messages.Where(filter).ToList();
        }

        public new Message Get(Expression<Func<Message, bool>> filter)
        {
            using Context context = new Context();
            var message = context.Set<Message>()
                .Include(x => x.Sender)
                .Include(x => x.Receiver)
                .SingleOrDefault(filter);

            return message;
        }
    }
}