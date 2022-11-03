using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class NewsLetter:IEntity
    {
        public NewsLetter()
        {
            Status = true;
        }


        public int Id { get; set; }
        
        public string Email { get; set; }
        
        public bool Status { get; set; }
    }
}
