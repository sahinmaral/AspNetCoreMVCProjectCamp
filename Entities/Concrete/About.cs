using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Core.Entities.Abstract;


namespace Entities.Concrete
{
    public class About: IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string Detail { get; set; }
        
        public string ImageUrl { get; set; }
        
        public string MapLocation { get; set; }
        
        public bool Status { get; set; }
    }
}