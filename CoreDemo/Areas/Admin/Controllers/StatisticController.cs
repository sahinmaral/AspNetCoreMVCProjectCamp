using AutoMapper;

using Business.Abstract;

using CoreDemo.Areas.Admin.Models;
using CoreDemo.Models;

using Entities.Concrete;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

using Newtonsoft.Json;

using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace CoreDemo.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class StatisticController : Controller
    {
        private readonly IBlogService _blogService;
        private readonly IContactService _contactService;
        private readonly IMessageService _messageService;
        private readonly ICommentService _commentService;
        private readonly IMapper _mapper;
        private readonly UserManager<AppUser> _userManager;

        public StatisticController(IBlogService blogService,
            IContactService contactService,
            IMessageService messageService,
            ICommentService commentService,
            IMapper mapper, UserManager<AppUser> userManager)
        {
            _blogService = blogService;
            _contactService = contactService;
            _messageService = messageService;
            _commentService = commentService;
            _mapper = mapper;
            _userManager = userManager;
        }
        public async Task<IActionResult> GetStatistics()
        {
            var weatherAppViewModel = GetWeatherAppViewModel();
            weatherAppViewModel.WeatherObjects[0].Icon = "http://openweathermap.org/img/wn/" +
                                                         weatherAppViewModel.WeatherObjects[0].Icon + ".png";

            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            ReadUserViewModel userViewModel = _mapper.Map(user, new ReadUserViewModel());

            ReadBlogViewModel lastBlogViewModel = new ReadBlogViewModel();
            lastBlogViewModel = _mapper.Map(_blogService.GetAllWithDetails().OrderByDescending(x => x.BlogCreatedDate).First(), lastBlogViewModel);

            ReadStatisticsViewModel viewModel = new ReadStatisticsViewModel
            {
                WeatherAppViewModel = weatherAppViewModel,
                TotalBlogCount = _blogService.GetAllWithDetails().Count,
                NewContactCount = _contactService.GetAll(x=>x.ContactStatus).Count,
                NewMessageCount = _messageService.GetAll(x=>x.Receiver.UserName == user.UserName && x.MessageOpened == false).Count,
                TotalCommentCount = _commentService.GetAll(x=>x.CommentStatus).Count,
                LastBlogViewModel = lastBlogViewModel,
                UserViewModel = userViewModel
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
