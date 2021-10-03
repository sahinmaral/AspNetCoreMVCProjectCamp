using System;
using System.Collections.Generic;
using Entities.Concrete;

namespace CoreDemo.Models
{
    public class ReadCategoryViewModel
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public bool CategoryStatus { get; set; }
    }
}
