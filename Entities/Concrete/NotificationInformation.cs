using Core.Entities.Abstract;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Concrete
{
    public class NotificationInformation: IEntity
    {

        [Key]
        [DatabaseGenerated((DatabaseGeneratedOption.Identity))]
        public int NotificationInformationsId { get; set; }

        public Notification Notification { get; set; }
        public int NotificationId { get; set; }

        public Language Language { get; set; }
        public int LanguageId { get; set; }

        public string NotificationHeader { get; set; }
        public string NotificationDetail { get; set; }


    }
}
