using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Areas.Admin.Models
{
    public class MessageTypeCountViewModel
    {
        public int ReceivedMessageCount { get; set; }
        public int SentMessageCount { get; set; }
    }
}
