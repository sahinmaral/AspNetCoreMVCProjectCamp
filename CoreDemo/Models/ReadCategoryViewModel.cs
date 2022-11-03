using System;
using System.Collections.Generic;
using Entities.Concrete;

namespace CoreDemo.Models
{
    public class ReadCategoryViewModel : BaseViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
    }
}
