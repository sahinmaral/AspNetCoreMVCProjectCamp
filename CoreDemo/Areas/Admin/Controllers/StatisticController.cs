using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AutoMapper;
using Business.Abstract;
using CoreDemo.Models;
using Entities.Concrete;
using Newtonsoft.Json;
using CoreDemo.Areas.Admin;
using CoreDemo.Areas.Admin.Models;
using System.Net.Http;
using System.IO;

namespace CoreDemo.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class StatisticController : Controller
    {
        private readonly IBlogService _blogService;
        private readonly IContactService _contactService;
        private readonly IMessageService _messageService;
        private readonly IAdminService _adminService;
        private readonly ICommentService _commentService;
        private readonly IWriterService _writerService;
        private readonly IMapper _mapper;

        public StatisticController(IBlogService blogService,
            IContactService contactService,
            IMessageService messageService,
            IAdminService adminService,
            ICommentService commentService,
            IWriterService writerService,
            IMapper mapper)
        {
            _blogService = blogService;
            _contactService = contactService;
            _messageService = messageService;
            _adminService = adminService;
            _commentService = commentService;
            _writerService = writerService;
            _mapper = mapper;
        }
        public IActionResult GetStatistics()
        {
            var weatherAppViewModel = GetWeatherAppViewModel();
            weatherAppViewModel.WeatherObjects[0].Icon = "http://openweathermap.org/img/wn/" +
                                                         weatherAppViewModel.WeatherObjects[0].Icon + ".png";

            string loggedWriterUsername = HttpContext.User.Claims.ToArray()[0].Subject.Name;

            Entities.Concrete.Admin admin = _adminService.Get(x => x.User.Username == loggedWriterUsername);

            ReadBlogViewModel lastBlogViewModel = new ReadBlogViewModel();
            lastBlogViewModel = _mapper.Map(_blogService.GetAllWithDetails().OrderByDescending(x => x.BlogCreatedDate).First(), lastBlogViewModel);

            ReadStatisticsViewModel viewModel = new ReadStatisticsViewModel
            {
                WeatherAppViewModel = weatherAppViewModel,
                TotalBlogCount = _blogService.GetAllWithDetails().Count,
                NewContactCount = _contactService.GetAll(x=>x.ContactStatus).Count,
                NewMessageCount = _messageService.GetAll(x=>x.Receiver.User.Username == admin.User.Username && x.MessageOpened == false).Count,
                TotalCommentCount = _commentService.GetAll(x=>x.CommentStatus).Count,
                LastBlog = lastBlogViewModel,
                WriterViewModel =  _mapper.Map(_writerService.Get(x => x.User.UserId == admin.User.UserId),new ReadWriterViewModel())
            };
            return View(viewModel);
        }

        public WeatherAppViewModel GetWeatherAppViewModel()
        {
            string path = "http://api.openweathermap.org/data/2.5/weather?q=istanbul&units=metric&appid=7beff515b2f3532f123f564d61a1b61b";

            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(string.Format(path));

            webRequest.Method = "GET";

            HttpWebResponse webResponse = (HttpWebResponse)webRequest.GetResponse();

            Console.WriteLine(webResponse.StatusCode);
            Console.WriteLine(webResponse.Server);

            string jsonString;
            using (Stream stream = webResponse.GetResponseStream())  
            {
                StreamReader reader = new StreamReader(stream, System.Text.Encoding.UTF8);
                jsonString = reader.ReadToEnd();
            }

            WeatherAppViewModel item = JsonConvert.DeserializeObject<WeatherAppViewModel>(jsonString);

            item.TemperatureObject = JsonConvert.DeserializeObject<WeatherAppMainObject>(item.TemperatureJson.ToString());
            item.WeatherObjects = JsonConvert.DeserializeObject<WeatherAppWeatherObject[]>(item.WeatherJson.ToString());

            return item;
        }

    }
}
