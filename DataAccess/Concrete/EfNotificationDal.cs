﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete
{
    public class EfNotificationDal : EfEntityRepositoryBase<Notification, Context>, INotificationDal
    {
        public List<Notification> GetAllWithDetails(Expression<Func<Notification, bool>> filter = null)
        {
            using Context context = new Context();
            var notifications = context.Notifications
                .Include(x => x.NotificationSymbol)
                .Include(r => r.NotificationInformations)
                .ThenInclude(p => (p as NotificationInformation).Language)
                .Include(x => x.NotificationType)
                ;

            return filter == null ? notifications.ToList() : notifications.Where(filter).ToList();
        }

        public Notification GetByIdWithDetails(int id)
        {
            using Context context = new Context();
            return context.Notifications
                .Include(x => x.NotificationSymbol)
                .Include(r => r.NotificationInformations)
                .ThenInclude(p => (p as NotificationInformation).Language)
                .Include(x => x.NotificationType)
                .SingleOrDefault(x => x.Id == id);
        }
    }
}