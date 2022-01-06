using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Concrete
{
    public class BlogRatio
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BlogRatioId { get; set; }

        public Blog Blog { get; set; }
        public int BlogId { get; set; }

        public decimal LikeRatio { get; set; }
        public decimal DislikeRatio { get; set; }

        public int TotalCommentsCount { get; set; }
    }
}
