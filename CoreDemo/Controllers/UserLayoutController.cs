using System.Linq;
using AutoMapper;
using Business.Abstract;
using CoreDemo.Models;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class UserLayoutController : Controller
    {
        private readonly IWriterService _writerService;
        private readonly IMapper _mapper;
        public UserLayoutController(IWriterService writerService, IMapper mapper)
        {
            _writerService = writerService;
            _mapper = mapper;
        }

        public PartialViewResult FooterPartialView()
        {
            return PartialView();
        }

        public PartialViewResult NavbarPartialView()
        {
            return PartialView();
        }
    }
}