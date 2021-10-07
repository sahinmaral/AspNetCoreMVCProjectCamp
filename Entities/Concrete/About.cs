using System.ComponentModel.DataAnnotations;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class About: IEntity
    {
        [Key]
        public int AboutId { get; set; }
        public string AboutDetails { get; set; }
        public string AboutImage { get; set; }
        public string AboutMapLocation { get; set; }
        public bool AboutStatus { get; set; }
    }
}