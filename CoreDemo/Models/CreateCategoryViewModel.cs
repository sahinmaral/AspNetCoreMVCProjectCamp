using System;
using System.Collections.Generic;
using Entities.Concrete;
using Slugify;

namespace CoreDemo.Models
{
    public class CreateCategoryViewModel : BaseViewModel
    {
        public string Name { get; set; }
        public string Slug
        {
            get
            {
                SlugHelper helper = new SlugHelper();
                return helper.GenerateSlug(Name);
            }

        }
        public string Description { get; set; }
    }
}
