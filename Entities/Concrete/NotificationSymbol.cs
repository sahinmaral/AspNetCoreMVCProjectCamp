using Core.Entities.Abstract;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public class NotificationSymbol:IEntity
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Notification> Notifications { get; set; }
    }
}