using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class NotificationTypeManager : INotificationTypeService
    {

        private readonly INotificationTypeDal _notificationTypeDal;

        public NotificationTypeManager(INotificationTypeDal notificationTypeDal)
        {
            _notificationTypeDal = notificationTypeDal;
        }
        public List<NotificationType> GetAll(Expression<Func<NotificationType, bool>> filter = null)
        {
            return _notificationTypeDal.GetAll(filter);
        }


        public NotificationType Get(Expression<Func<NotificationType, bool>> filter = null)
        {
            return _notificationTypeDal.Get(filter);
        }

        public void Add(NotificationType entity)
        {
            _notificationTypeDal.Add(entity);
        }

        public void Delete(NotificationType entity)
        {
            _notificationTypeDal.Delete(entity);
        }

        public void Update(NotificationType entity)
        {
            _notificationTypeDal.Update(entity);
        }
    }
}
