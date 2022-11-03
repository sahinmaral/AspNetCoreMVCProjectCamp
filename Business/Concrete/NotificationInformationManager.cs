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
    public class NotificationInformationManager : INotificationInformationService
    {

        private readonly INotificationInformationDal _notificationInformationDal;

        public NotificationInformationManager(INotificationInformationDal notificationInformationDal)
        {
            _notificationInformationDal = notificationInformationDal;
        }
        public List<NotificationInformation> GetAll(Expression<Func<NotificationInformation, bool>> filter = null)
        {
            return _notificationInformationDal.GetAll(filter);
        }


        public NotificationInformation Get(Expression<Func<NotificationInformation, bool>> filter = null)
        {
            return _notificationInformationDal.Get(filter);
        }

        public void Add(NotificationInformation entity)
        {
            _notificationInformationDal.Add(entity);
        }

        public void Delete(NotificationInformation entity)
        {
            _notificationInformationDal.Delete(entity);
        }

        public void Update(NotificationInformation entity)
        {
            _notificationInformationDal.Update(entity);
        }
    }
}
