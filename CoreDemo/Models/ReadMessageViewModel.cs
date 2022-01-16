﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Concrete;

namespace CoreDemo.Models
{
    public class ReadMessageViewModel
    {
        public int MessageId { get; set; }
        public ReadWriterViewModel Sender { get; set; }
        public ReadWriterViewModel Receiver { get; set; }

        public string MessageSubject { get; set; }
        public string MessageDetail { get; set; }
        public DateTime MessageDateTime { get; set; }
        public bool MessageOpened { get; set; }
    }
}
