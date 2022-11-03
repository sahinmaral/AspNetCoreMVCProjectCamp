using Core.Entities.Abstract;
namespace Entities.Concrete
{
    public class NotificationInformation: IEntity
    {
        public int Id { get; set; }

        public Notification Notification { get; set; }
        public int NotificationId { get; set; }

        public Language Language { get; set; }
        public int LanguageId { get; set; }

        public string Header { get; set; }
        public string Detail { get; set; }


    }
}
