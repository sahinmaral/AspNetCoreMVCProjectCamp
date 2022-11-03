using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace CoreDemo.Models
{
    public class ReadNotificationViewModel
    {
        public int Id { get; set; }

        public NotificationType NotificationType { get; set; }

        public NotificationSymbol NotificationSymbol { get; set; }

        public bool Status { get; set; }
        public DateTime CreatedAt { get; set; }

        public List<NotificationInformation> NotificationInformations { get; set; }
    }
}
