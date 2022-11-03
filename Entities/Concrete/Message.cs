using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Message : IEntity
    {
        public Message()
        {
            IsMessageOpened = false;
            CreatedAt = DateTime.Now;
        }


        public int Id { get; set; }

        [Column("SenderId")]
        public int? SenderId { get; set; }
        public User Sender { get; set; }

        [Column("ReceiverId")]
        public int? ReceiverId { get; set; }
        public User Receiver { get; set; }

        public string Subject { get; set; }
        public string Detail { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsMessageOpened { get; set; }
    }
}
