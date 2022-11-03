using Core.Entities.Abstract;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Concrete
{
    public class Notification : IEntity
    {
        public Notification()
        {
            CreatedAt = DateTime.Now;
            Status = true;
        }
        public int Id { get; set; }

        public NotificationType NotificationType { get; set; }
        public int NotificationTypeId { get; set; }

        public NotificationSymbol NotificationSymbol { get; set; }
        public int NotificationSymbolId { get; set; }

        public bool Status { get; set; }
        public DateTime CreatedAt { get; set; }

        public ICollection<NotificationInformation> NotificationInformations { get; set; }

    }
}
