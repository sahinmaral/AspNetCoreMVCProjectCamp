using System.Linq;
using AutoMapper;
using Business.Abstract;
using CoreDemo.Models;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents
{
    public class LoginRegisterNavbarViewComponent : ViewComponent
    {
        private readonly IWriterService _writerService;
        private readonly IMapper _mapper;

        public LoginRegisterNavbarViewComponent(IMapper mapper, IWriterService writerService)
        {
            _mapper = mapper;
            _writerService = writerService;
        }

        public IViewComponentResult Invoke()
        {
            if (!HttpContext.User.Claims.Any())
            {
                return View(new ReadWriterViewModel());
            }
            
            string loggedWriterUsername = HttpContext.User.Claims.Single().Subject.Name;

            Writer writer = _writerService.Get(x => x.WriterUsername == loggedWriterUsername);

            ReadWriterViewModel viewModel = new ReadWriterViewModel();

            viewModel = _mapper.Map(writer, viewModel);

            return View(viewModel);

        }
    }
}