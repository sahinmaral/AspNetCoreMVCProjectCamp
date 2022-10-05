using AutoMapper;
using Business.Abstract;
using CoreDemo.Models;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CoreDemo.Areas.Admin.Controllers
{

    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class AboutController : Controller
    {
        private readonly IAboutService _aboutService;
        private readonly IMapper _mapper;
        public AboutController(IAboutService aboutService,IMapper mapper)
        {
            _aboutService = aboutService;
            _mapper = mapper;
        }

        public IActionResult GetAbouts()
        {
            List<ReadAboutViewModel> aboutViewModels = _mapper.Map(_aboutService.GetAll(),new List<ReadAboutViewModel>());

            return View(aboutViewModels);
        }

        [HttpGet]
        public IActionResult UpdateAbout(int id)
        {
            return View(_mapper.Map(_aboutService.Get(x => x.AboutId == id), new ReadAboutViewModel()));
        }

        [HttpPost]
        public IActionResult UpdateAbout(ReadAboutViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }

            About updatedAbout = _aboutService.Get(x => x.AboutId == viewModel.AboutId);
            updatedAbout.AboutDetail = viewModel.AboutDetail;
            updatedAbout.AboutMapLocation = viewModel.AboutMapLocation;
            updatedAbout.AboutImage = viewModel.AboutImage;

            _aboutService.Update(updatedAbout);

            return RedirectToAction(nameof(GetAbouts) , nameof(AboutController).Replace("Controller", ""));
        }

        [HttpPost]
        public IActionResult EnableAbout(int id)
        {
            _aboutService.GetAll().ForEach(x =>
            {
                if (x.AboutId == id) x.AboutStatus = true;
                else x.AboutStatus = false;

                _aboutService.Update(x);
            });

            return RedirectToAction(nameof(GetAbouts));
        }

    }
}
