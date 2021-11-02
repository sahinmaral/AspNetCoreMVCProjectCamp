using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Business.Abstract;
using CoreDemo.Models;
using Microsoft.AspNetCore.Authorization;

namespace CoreDemo.Controllers
{
    [AllowAnonymous]
    public class AboutController : Controller
    {
        private readonly IAboutService _aboutService;
        private readonly IMapper _mapper;
        public AboutController(IAboutService aboutService, IMapper mapper)
        {
            _aboutService = aboutService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            ReadAboutViewModel viewModel = new ReadAboutViewModel();

            viewModel = _mapper.Map(_aboutService.Get(x => x.AboutStatus == true), viewModel);

            return View(viewModel);
        }
    }
}
