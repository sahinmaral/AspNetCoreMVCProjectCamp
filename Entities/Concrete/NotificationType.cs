using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class NotificationType : IEntity
    {
        [Key]
        public int NotificationTypeId { get; set; }
        public string NotificationTypeName { get; set; }

        public ICollection<Notification> Notifications { get; set; }
    }
}