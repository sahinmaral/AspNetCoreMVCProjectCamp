using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents
{
    public class NotificationListViewComponent : ViewComponent
    {
        private readonly INotificationService _notificationService;

        public NotificationListViewComponent(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }
        public IViewComponentResult Invoke()
        {
            return View(_notificationService.GetAll(x=>x.NotificationStatus)
                .OrderByDescending(x=>x.NotificationDate)
                .Take(3).ToList());
        }
    }
}
