using Core.Entities.Abstract;
using System;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class Contact:IEntity
    {
        public Contact()
        {
            CreatedAt = DateTime.Now;
            IsOpened = false;
            IsAnswered = false;
        }
        
        [Key]
        public int Id { get; set; }
        
        public string NameSurname { get; set; }

        public string Email { get; set; }
        
        public string Subject { get; set; }
        
        public string Message { get; set; }
        
        public DateTime CreatedAt { get; set; }
        
        public bool IsOpened { get; set; }
        public bool IsAnswered { get; set; }
    }
}