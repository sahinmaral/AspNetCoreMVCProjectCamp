using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace CoreDemo.Areas.Writer.Models
{
    public class ReadNotificationViewModel
    {
        public int NotificationId { get; set; }

        public NotificationType NotificationType { get; set; }

        public NotificationSymbol NotificationSymbol { get; set; }

        public bool NotificationStatus { get; set; }
        public DateTime NotificationDate { get; set; }

        public ICollection<NotificationInformation> NotificationInformations { get; set; }
    }
}
