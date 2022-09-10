using System.Linq;
using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Areas.Writer.ViewComponents
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
