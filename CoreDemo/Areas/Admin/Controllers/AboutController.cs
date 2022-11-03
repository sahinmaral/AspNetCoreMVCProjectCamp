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
        public IActionResult AddAbout()
        {
            return View(new CreateAboutViewModel());
        }

        [HttpPost]
        public IActionResult AddAbout(CreateAboutViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }

            About newAbout = _mapper.Map(viewModel, new About());
            _aboutService.Add(newAbout);

            return RedirectToAction(nameof(GetAbouts), nameof(AboutController).Replace("Controller", ""));
        }

        [HttpGet]
        public IActionResult UpdateAbout(int id)
        {
            return View(_mapper.Map(_aboutService.Get(x => x.Id == id), new ReadAboutViewModel()));
        }

        [HttpPost]
        public IActionResult UpdateAbout(ReadAboutViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }

            About updatedAbout = _aboutService.Get(x => x.Id == viewModel.Id);
            updatedAbout.Detail = viewModel.Detail;
            updatedAbout.MapLocation = viewModel.MapLocation;
            updatedAbout.ImageUrl = viewModel.ImageUrl;

            _aboutService.Update(updatedAbout);

            return RedirectToAction(nameof(GetAbouts) , nameof(AboutController).Replace("Controller", ""));
        }

        [HttpPost]
        public IActionResult EnableAbout(int id)
        {
            _aboutService.GetAll().ForEach(x =>
            {
                if (x.Id == id) x.Status = true;
                else x.Status = false;

                _aboutService.Update(x);
            });

            return RedirectToAction(nameof(GetAbouts));
        }

    }
}
