using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Business.Abstract;
using CoreDemo.Models;
using Entities.Concrete;
using Newtonsoft.Json;

namespace CoreDemo.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class WriterController : Controller
    {
        private readonly IWriterService _writerService;
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public WriterController(IWriterService writerService,IUserService userService,IMapper mapper)
        {
            _writerService = writerService;
            _userService = userService;
            _mapper = mapper;
        }
        public IActionResult GetWriters()
        {
            return View();
        }

        public IActionResult GetWritersJson()
        {
            var writers = _mapper.Map(_writerService.GetAll(), new List<ReadWriterViewModel>());

            var jsonWriters = JsonConvert.SerializeObject(writers);

            return Json(jsonWriters);
        }


        public IActionResult GetWriterByIdJson(int id)
        {
            var writer = _mapper.Map(_writerService.Get(x=>x.WriterId == id), new ReadWriterViewModel());

            var jsonWriter = JsonConvert.SerializeObject(writer);

            return Json(jsonWriter);
        }

        public void EnableOrDisableWriter(int id)
        {
            Writer writer = _writerService.Get(x => x.WriterId == id);

            if (writer.User.Status)
                writer.User.Status = false;
            else
                writer.User.Status = true;

            _userService.Update(writer.User);

        }
    }
}
