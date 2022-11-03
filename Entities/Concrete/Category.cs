using Core.Entities.Abstract;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public class Category:IEntity
    {
        public Category()
        {
            Status = true;
        }

        public int Id { get; set; }
        
        public string Name { get; set; }
        public string Slug { get; set; }

        public string Description { get; set; }

        public bool Status { get; set; }

        public ICollection<Blog> Blogs { get; set; }
    }
}