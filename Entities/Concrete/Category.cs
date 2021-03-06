using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Category:IEntity
    {
        public Category()
        {
            CategoryStatus = true;
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryId { get; set; }
        
        public string CategoryName { get; set; }
        
        public string CategoryDescription { get; set; }

        public bool CategoryStatus { get; set; }

        public ICollection<Blog> Blogs { get; set; }
    }
}