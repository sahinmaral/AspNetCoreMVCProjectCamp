using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class Blog:IEntity
    {
        public Blog()
        {
            BlogCreatedDate = DateTime.Now;
            BlogStatus = true;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("blog_id")]
        public int BlogId { get; set; }
        
        [Column("blog_title")]
        public string BlogTitle { get; set; }
        
        [Column("blog_content")]
        public string BlogContent { get; set; }
        
        [Column("blog_thumbnail_image")]
        public string BlogThumbnailImage { get; set; }
        
        [Column("blog_main_image")]
        public string BlogMainImage { get; set; }
        
        [Column("blog_created_date")]
        public DateTime BlogCreatedDate { get; set; }
        
        [Column("blog_status")]
        public bool BlogStatus { get; set; }

        [Column("category_id")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public ICollection<Comment> Comments { get; set; }

        [Column("writer_id")]
        public int WriterId { get; set; }
        public Writer Writer { get; set; }
    }
}