using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Entities.Abstract;

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
        [Column("contact_id")]
        public int ContactId { get; set; }
        
        [Column("contact_name")]
        public string ContactName { get; set; }
        
        [Column("contact_surname")]
        public string ContactSurname { get; set; }
        
        [Column("contact_mail")]
        public string ContactMail { get; set; }
        
        [Column("contact_subject")]
        public string ContactSubject { get; set; }
        
        [Column("contact_message")]
        public string ContactMessage { get; set; }
        
        [Column("contact_created_date")]
        public DateTime ContactCreatedDate { get; set; }
        
        [Column("contact_status")]
        public bool ContactStatus { get; set; }
    }
}