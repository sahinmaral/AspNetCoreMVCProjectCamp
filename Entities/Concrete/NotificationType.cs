﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class NotificationType : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Notification> Notifications { get; set; }
    }
}