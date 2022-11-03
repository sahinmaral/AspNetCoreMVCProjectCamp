using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Concrete;

namespace CoreDemo.Models
{
    public class ReadMessageViewModel : BaseViewModel
    {
        public int Id { get; set; }
        public ReadUserViewModel Sender { get; set; }
        public ReadUserViewModel Receiver { get; set; }

        public string Subject { get; set; }
        public string Detail { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsMessageOpened { get; set; }
    }
}
