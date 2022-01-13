using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class Notification : IEntity
    {
        [Key]
        public int NotificationId { get; set; }

        public string NotificationHeader { get; set; }

        public NotificationType NotificationType { get; set; }
        public int NotificationTypeId { get; set; }

        public NotificationSymbol NotificationSymbol { get; set; }
        public int NotificationSymbolId { get; set; }

        public string NotificationDetail { get; set; }
        public bool NotificationStatus { get; set; }
        public DateTime NotificationDate { get; set; }

    }
}
