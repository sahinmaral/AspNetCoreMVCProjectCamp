using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class NotificationSymbolManager : INotificationSymbolService
    {

        private readonly INotificationSymbolDal _notificationSymbolDal;

        public NotificationSymbolManager(INotificationSymbolDal notificationSymbolDal)
        {
            _notificationSymbolDal = notificationSymbolDal;
        }
        public List<NotificationSymbol> GetAll(Expression<Func<NotificationSymbol, bool>> filter = null)
        {
            return _notificationSymbolDal.GetAll(filter);
        }


        public NotificationSymbol Get(Expression<Func<NotificationSymbol, bool>> filter = null)
        {
            return _notificationSymbolDal.Get(filter);
        }

        public void Add(NotificationSymbol entity)
        {
            _notificationSymbolDal.Add(entity);
        }

        public void Delete(NotificationSymbol entity)
        {
            _notificationSymbolDal.Delete(entity);
        }

        public void Update(NotificationSymbol entity)
        {
            _notificationSymbolDal.Update(entity);
        }
    }
}
