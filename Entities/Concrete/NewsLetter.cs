using Entities.Abstract;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Concrete
{
    public class NewsLetter:IEntity
    {
        public NewsLetter()
        {
            NewsLetterStatus = true;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("newsletter_id")]
        public int NewsLetterId { get; set; }
        
        [Column("newsletter_mail")]
        public string NewsLetterMail { get; set; }
        
        [Column("newsletter_status")]
        public bool NewsLetterStatus { get; set; }
    }
}
