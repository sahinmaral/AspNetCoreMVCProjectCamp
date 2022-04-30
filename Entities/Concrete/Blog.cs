using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Core.Entities.Abstract;

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
        public int BlogId { get; set; }

        public string BlogTitle { get; set; }
        
        public string BlogContent { get; set; }

        public string BlogThumbnailImage { get; set; }
        
        public string BlogMainImage { get; set; }
        
        public DateTime BlogCreatedDate { get; set; }
        
        public bool BlogStatus { get; set; }

        [Column("CategoryId")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public ICollection<Comment> Comments { get; set; }

        [Column("UserId")]
        public int UserId { get; set; }
        public AppUser User { get; set; }

        public BlogRatio BlogRatio { get; set; }
    }
}