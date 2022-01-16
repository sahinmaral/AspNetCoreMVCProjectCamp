﻿using System.Linq;
using AutoMapper;
using Business.Abstract;
using CoreDemo.Models;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents
{
    public class WriterSidebarViewComponent : ViewComponent
    {
        private readonly IWriterService _writerService;
        private readonly IMapper _mapper;

        public WriterSidebarViewComponent(IMapper mapper, IWriterService writerService)
        {
            _mapper = mapper;
            _writerService = writerService;
        }
        
        public IViewComponentResult Invoke()
        {
            string loggedWriterUsername = HttpContext.User.Claims.ToArray()[0].Subject.Name;

            Writer writer = _writerService.Get(x => x.User.Username == loggedWriterUsername);

            ReadWriterViewModel writerViewModel = new ReadWriterViewModel();

            writerViewModel = _mapper.Map(writer, writerViewModel);
            
            return View(writerViewModel);
        }
    }
}