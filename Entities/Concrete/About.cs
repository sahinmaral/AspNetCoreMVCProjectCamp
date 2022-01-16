using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Core.Entities.Abstract;


namespace Entities.Concrete
{
    public class About: IEntity
    {
        [Key]
        [DatabaseGenerated((DatabaseGeneratedOption.Identity))]
        public int AboutId { get; set; }
        
        public string AboutDetail { get; set; }
        
        public string AboutImage { get; set; }
        
        public string AboutMapLocation { get; set; }
        
        public bool AboutStatus { get; set; }
    }
}