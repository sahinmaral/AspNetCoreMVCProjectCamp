using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class Writer:IEntity
    {
        public Writer()
        {
            WriterStatus = true;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("writer_id")]
        public int WriterId { get; set; }
        
        [Column("writer_username")]
        public string WriterUsername { get; set; }
        
        [Column("writer_name")]
        public string WriterName { get; set; }

        [Column("writer_surname")]
        public string WriterSurname { get; set; }
        
        [Column("writer_about")]
        public string WriterAbout { get; set; }
        
        [Column("writer_image")]
        public string WriterImage { get; set; }
        
        [Column("writer_mail")]
        public string WriterMail { get; set; }
        
        [Column("writer_password")]
        public string WriterPassword { get; set; }
        
        [Column("writer_status")]
        public bool WriterStatus { get; set; }

        public ICollection<Blog> Blogs { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}