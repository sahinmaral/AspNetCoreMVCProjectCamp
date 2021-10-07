using System;
using System.ComponentModel.DataAnnotations;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class Contact:IEntity
    {
        public Contact()
        {
            ContactCreateDate = DateTime.Now;
            ContactStatus = true;
        }
        
        [Key]
        public int ContactId { get; set; }
        public string ContactName { get; set; }
        public string ContactSurname { get; set; }
        public string ContactMail { get; set; }
        public string ContactSubject { get; set; }
        public string ContactMessage { get; set; }
        public DateTime ContactCreateDate { get; set; }
        public bool ContactStatus { get; set; }
    }
}