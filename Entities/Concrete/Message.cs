using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class Message : IEntity
    {
        public Message()
        {
            MessageOpened = false;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MessageId { get; set; }

        [Column("SenderId")]
        public int? SenderId { get; set; }
        public Writer Sender { get; set; }

        [Column("ReceiverId")]
        public int? ReceiverId { get; set; }
        public Writer Receiver { get; set; }

        public string MessageSubject { get; set; }
        public string MessageDetail { get; set; }
        public DateTime MessageDateTime { get; set; }
        public bool MessageOpened { get; set; }
    }
}
