using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class NotificationType : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int NotificationTypeId { get; set; }
        public string NotificationTypeName { get; set; }

        public ICollection<Notification> Notifications { get; set; }
    }
}