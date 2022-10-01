﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface INotificationService : IGenericRepositoryService<Notification>
    {
        public List<Notification> GetAllWithDetails(Expression<Func<Notification, bool>> filter = null);
    }
}
