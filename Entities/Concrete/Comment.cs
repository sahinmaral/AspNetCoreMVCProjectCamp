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
        [Column("comment_id")]
        public int CommentId { get; set; }
        
        [Column("comment_about")]
        public string CommentAbout { get; set; }
        
        [Column("comment_created_date")]
        public DateTime CommentCreatedDate { get; set; }
        
        [Column("comment_status")]
        public bool CommentStatus { get; set; }

        [Column("blog_id")]
        public int BlogId { get; set; }
        public Blog Blog { get; set; }

        [Column("writer_id")]
        public int WriterId { get; set; }
        public Writer Writer { get; set; }
    }
}