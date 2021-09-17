using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class Category:IEntity
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public bool CategoryStatus { get; set; }
        public ICollection<Blog> Blogs { get; set; }
    }
}