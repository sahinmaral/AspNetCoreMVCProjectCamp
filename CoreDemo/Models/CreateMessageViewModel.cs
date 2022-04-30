using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Models
{
    public class CreateMessageViewModel
    {
        public ReadUserViewModel Sender { get; set; }
        public ReadUserViewModel Receiver { get; set; }

        public string MessageSubject { get; set; }
        public string MessageDetail { get; set; }
    }
}
