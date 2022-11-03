using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreDemo.Areas.Admin.Models;

namespace CoreDemo.Models
{
    public class ReadStatisticsViewModel : BaseViewModel
    {
        public int TotalBlogCount { get; set; }
        public int NewContactCount { get; set; }
        public int NewMessageCount { get; set; }
        public int TotalCommentCount { get; set; }
        public ReadBlogViewModel LastBlogViewModel { get; set; }
        public WeatherAppViewModel WeatherAppViewModel { get; set; }
        public ReadUserViewModel UserViewModel { get; set; }
    }
}
