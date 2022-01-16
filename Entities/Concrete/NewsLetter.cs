using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Core.Entities.Abstract;

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
        public int NewsLetterId { get; set; }
        
        public string NewsLetterMail { get; set; }
        
        public bool NewsLetterStatus { get; set; }
    }
}
