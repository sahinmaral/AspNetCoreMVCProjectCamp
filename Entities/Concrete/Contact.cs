using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Contact:IEntity
    {
        public Contact()
        {
            ContactCreatedDate = DateTime.Now;
            ContactStatus = true;
        }
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ContactId { get; set; }
        
        public string ContactName { get; set; }
        
        public string ContactSurname { get; set; }
        
        public string ContactMail { get; set; }
        
        public string ContactSubject { get; set; }
        
        public string ContactMessage { get; set; }
        
        public DateTime ContactCreatedDate { get; set; }
        
        public bool ContactStatus { get; set; }
    }
}