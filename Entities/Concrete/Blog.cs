using Core.Entities.Abstract;
using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public class Blog : IEntity
    {
        public Blog()
        {
            CreatedAt = DateTime.Now;
            Status = true;
        }

        public int Id { get; set; }

        public string Title { get; set; }
        public string Slug { get; set; }

        public string Content { get; set; }

        public string ThumbnailImage { get; set; }

        public string MainImage { get; set; }

        public DateTime CreatedAt { get; set; }

        public bool Status { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public ICollection<Comment> Comments { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public BlogRatio BlogRatio { get; set; }
    }
}