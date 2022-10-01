using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface INotificationDal : IEntityRepository<Notification>
    {
        public List<Notification> GetAllWithDetails(Expression<Func<Notification, bool>> filter = null);
    }
}
