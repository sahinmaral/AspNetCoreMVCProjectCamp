using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class NotificationManager: INotificationService
    {
        private readonly INotificationDal _notificationDal;

        public NotificationManager(INotificationDal notificationDal)
        {
            _notificationDal = notificationDal;
        }
        public List<Notification> GetAll(Expression<Func<Notification, bool>> filter = null)
        {
            return _notificationDal.GetAll(filter);
        }

        public Notification Get(Expression<Func<Notification, bool>> filter = null)
        {
            return _notificationDal.Get(filter);
        }

        public void Add(Notification entity)
        {
            _notificationDal.Add(entity);
        }

        public void Delete(Notification entity)
        {
            _notificationDal.Delete(entity);
        }

        public void Update(Notification entity)
        {
            _notificationDal.Update(entity);
        }
    }
}
