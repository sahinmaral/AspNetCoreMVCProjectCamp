using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class About: IEntity
    {
        [Key]
        [DatabaseGenerated((DatabaseGeneratedOption.Identity))]
        [Column("about_id")]
        public int AboutId { get; set; }
        
        [Column("about_detail")]
        public string AboutDetail { get; set; }
        
        [Column("about_image")]
        public string AboutImage { get; set; }
        
        [Column("about_map_location")]
        public string AboutMapLocation { get; set; }
        
        [Column("about_status")]
        public bool AboutStatus { get; set; }
    }
}