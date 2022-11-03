using System;
using System.ComponentModel.DataAnnotations.Schema;
using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Comment:IEntity
    {
        public Comment()
        {
            CreatedAt = DateTime.Now;
            Status = true;
        }
        
        public int Id { get; set; }
        
        public string Detail { get; set; }

        public DateTime CreatedAt { get; set; }
        
        public bool Status { get; set; }

        public int BlogId { get; set; }
        public Blog Blog { get; set; }

        public int? UserId { get; set; }
        public User User { get; set; }

        public bool LikeOrDislikeStatus { get; set; }
    }
}