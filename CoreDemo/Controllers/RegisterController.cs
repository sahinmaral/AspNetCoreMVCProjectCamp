﻿using System;
using AutoMapper;

using Business.Abstract;

using CoreDemo.Models;

using Entities.Concrete;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

using System.Collections.Generic;
using System.IO;
using System.Linq;
using Core.Entities.Concrete;
using Core.Utilities.Security.Hashing;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;

namespace CoreDemo.Controllers
{
    [AllowAnonymous]
    public class RegisterController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IWriterService _writerService;
        public RegisterController(IMapper mapper, IWriterService writerService)
        {
            _mapper = mapper;
            _writerService = writerService;
        }

        public void GetCities()
        {
            List<string> cities = new List<string>()
            {
                "", "Adana", "Adıyaman", "Afyon", "Ağrı", "Amasya", "Ankara", "Antalya", "Artvin",
                "Aydın", "Balıkesir", "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa", "Çanakkale",
                "Çankırı", "Çorum", "Denizli", "Diyarbakır", "Edirne", "Elazığ", "Erzincan", "Erzurum", "Eskişehir",
                "Gaziantep", "Giresun", "Gümüşhane", "Hakkari", "Hatay", "Isparta", "Mersin", "İstanbul", "İzmir",
                "Kars", "Kastamonu", "Kayseri", "Kırklareli", "Kırşehir", "Kocaeli", "Konya", "Kütahya", "Malatya",
                "Manisa", "Kahramanmaraş", "Mardin", "Muğla", "Muş", "Nevşehir", "Niğde", "Ordu", "Rize", "Sakarya",
                "Samsun", "Siirt", "Sinop", "Sivas", "Tekirdağ", "Tokat", "Trabzon", "Tunceli", "Şanlıurfa", "Uşak",
                "Van", "Yozgat", "Zonguldak", "Aksaray", "Bayburt", "Karaman", "Kırıkkale", "Batman", "Şırnak",
                "Bartın", "Ardahan", "Iğdır", "Yalova", "Karabük", "Kilis", "Osmaniye", "Düzce"
            };

            List<SelectListItem> citieSelectListItems = (from x in cities
                                                         select new SelectListItem()
                                                         {
                                                             Text = x,
                                                             Value = x
                                                         }).ToList();

            ViewBag.Cities = citieSelectListItems;
        }

        [HttpGet]
        public IActionResult RegisterWriter()
        {
            GetCities();

            return View();
        }

        [HttpPost]
        public IActionResult RegisterWriter(RegisterWriterViewModel viewModel)
        {

            if (!ModelState.IsValid)
            {

                GetCities();

                return View(viewModel);
            }

            Writer writer = new Writer();

            writer = _mapper.Map(viewModel, writer);

            string[] splittedNameSurname = viewModel.WriterName.Split(' ');

            writer.User = new User();

            writer.User.Username = viewModel.WriterUsername;
            writer.User.UserFirstName = splittedNameSurname[0];

            if (splittedNameSurname.Length == 2)
                writer.User.UserLastName = splittedNameSurname[1];
            else if(splittedNameSurname.Length > 2)
                writer.User.UserLastName = splittedNameSurname[1] + " " + splittedNameSurname[2];
            else
            {
                ModelState.AddModelError("WriterName", "Soyadı yazmanız gerekiyor.");
            }

            writer.WriterImage = AssignFormFileAndReturnName(viewModel.WriterImage);

            HashingHelper.CreatePasswordHash(viewModel.WriterPassword,out var passwordHash,out var passwordSalt);

            writer.User.UserPasswordSalt = passwordSalt;
            writer.User.UserPasswordHash = passwordHash;

            _writerService.Add(writer);

            return RedirectToAction("GetAll", "Blog");

        }

        private string AssignFormFileAndReturnName(IFormFile file)
        {
            var extension = Path.GetExtension(file.FileName);

            var newName = Guid.NewGuid() + extension;
            var location = Path.Combine(Directory.GetCurrentDirectory() + @"\wwwroot\writerProfileImages\", newName);
            var stream = new FileStream(location, FileMode.Create);
            file.CopyTo(stream);

            return newName;
        }

    }

}
