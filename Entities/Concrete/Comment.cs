using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Entities.Abstract;

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
        public int BlogId { get; set; }
        public Blog Blog { get; set; }

        [Column("WriterId")]
        public int? WriterId { get; set; }
        public Writer Writer { get; set; }

        public bool LikeOrDislikeStatus { get; set; }
    }
}