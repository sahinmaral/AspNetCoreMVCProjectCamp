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
        private readonly IMapper _mapper;

        public WriterController(IMapper mapper)
        {
            _mapper = mapper;
        }
        public IActionResult GetWriters()
        {
            return View();
        }

        public IActionResult GetWritersJson()
        {
            //TODO : Writer rolu olan kullanicilari getir

            //var jsonWriters = JsonConvert.SerializeObject(writers);

            //return Json(jsonWriters);

            return Json(null);
        }


        public IActionResult GetWriterByIdJson(int id)
        {
            //TODO : Writer rolu olan kullaniciyi ID'ye gore getir

            //var jsonWriters = JsonConvert.SerializeObject(writers);

            //return Json(jsonWriters);

            return Json(null);
        }

        public void EnableOrDisableWriter(int id)
        {
            //TODO : Kullaniciyi banlama veya rolunu silme 

            //Writer writer = _writerService.Get(x => x.WriterId == id);

            //if (writer.User.Status)
            //    writer.User.Status = false;
            //else
            //    writer.User.Status = true;

            //_userService.Update(writer.User);

        }
    }
}
