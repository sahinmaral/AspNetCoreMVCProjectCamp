using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Comment:IEntity
    {
        public Comment()
        {
            CommentCreatedDate = DateTime.Now;
            CommentStatus = true;
        }
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CommentId { get; set; }
        
        public string CommentAbout { get; set; }

        public DateTime CommentCreatedDate { get; set; }
        
        public bool CommentStatus { get; set; }

        [Column("BlogId")]
        public int? BlogId { get; set; }
        public Blog Blog { get; set; }

        [Column("UserId")]
        public int? UserId { get; set; }
        public AppUser User { get; set; }

        public bool LikeOrDislikeStatus { get; set; }
    }
}