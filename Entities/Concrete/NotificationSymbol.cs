using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class NotificationSymbol:IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int NotificationSymbolId { get; set; }
        public string SymbolName { get; set; }

        public ICollection<Notification> Notifications { get; set; }
    }
}