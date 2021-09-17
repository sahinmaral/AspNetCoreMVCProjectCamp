using System;
using System.ComponentModel.DataAnnotations;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class Comment:IEntity
    {
        public Comment()
        {
            CommentCreateDate = DateTime.Now;
        }
        
        [Key]
        public int CommentId { get; set; }
        public string CommentUsername { get; set; }
        public string CommentAbout { get; set; }
        public DateTime CommentCreateDate { get; set; }
        public bool CommentStatus { get; set; }

        public Blog Blog { get; set; }
        public int BlogId { get; set; }
    }
}