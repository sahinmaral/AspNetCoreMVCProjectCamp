using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class Category:IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("category_id")]
        public int CategoryId { get; set; }
        
        [Column("category_name")]
        public string CategoryName { get; set; }
        
        [Column("category_description")]
        public string CategoryDescription { get; set; }
        
        [Column("category_status")]
        public bool CategoryStatus { get; set; }
        public ICollection<Blog> Blogs { get; set; }
    }
}