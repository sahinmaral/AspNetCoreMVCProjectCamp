using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Concrete
{
    public class BlogRatio
    {
        public int Id { get; set; }

        public Blog Blog { get; set; }
        public int BlogId { get; set; }

        public decimal LikeRatio { get; set; }
        public decimal DislikeRatio { get; set; }

    }
}
