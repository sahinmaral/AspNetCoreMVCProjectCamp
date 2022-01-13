using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class NotificationSymbol:IEntity
    {
        [Key]
        public int NotificationSymbolId { get; set; }
        public string SymbolName { get; set; }

        public ICollection<Notification> Notifications { get; set; }
    }
}