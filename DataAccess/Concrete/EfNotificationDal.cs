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
    public class EfNotificationDal:EfEntityRepositoryBase<Notification, Context> , INotificationDal
    {
        public new List<Notification> GetAll(Expression<Func<Notification, bool>> filter = null)
        {
            using Context context = new Context();
            var notifications =  context.Notifications
                .Include(x => x.NotificationSymbol)
                .Include(x => x.NotificationType);

            return filter == null ? notifications.ToList() : notifications.Where(filter).ToList();
        }
    }
}