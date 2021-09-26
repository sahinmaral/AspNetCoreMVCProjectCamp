using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Models
{
    public class CommentViewModel
    {
        public int CommentId { get; set; }
        public string CommentUsername { get; set; }
        public string CommentAbout { get; set; }
        public string CommentCreateDate { get; set; }
        public bool CommentStatus { get; set; }
        public int BlogId { get; set; }
    }
}
