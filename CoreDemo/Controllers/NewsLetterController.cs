﻿using AutoMapper;

using Business.Abstract;

using Core.Helper.Toastr;
using Core.Helper.Toastr.OptionEnums;

using CoreDemo.Models;

using Entities.Concrete;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

using System;
using System.Linq;

namespace CoreDemo.Controllers
{
    [AllowAnonymous]
    public class NewsLetterController : Controller
    {

        private readonly INewsLetterService _newsLetterService;
        private readonly IStringLocalizer<NewsLetterController> _stringLocalizer;
        private readonly IMapper _mapper;
        public NewsLetterController(INewsLetterService newsLetterService, IMapper mapper, IStringLocalizer<NewsLetterController> stringLocalizer)
        {
            _newsLetterService = newsLetterService;
            _mapper = mapper;
            _stringLocalizer = stringLocalizer;
        }

        [HttpPost]
        public IActionResult SubscribeEmail(CreateNewsLetterViewModel viewModel)
        {

            if (!ModelState.IsValid)
            {
                var modelErrors = ModelState.Values.SelectMany(x => x.Errors);

                var errors = "";

                foreach (var error in modelErrors)
                {
                    errors += error.ErrorMessage;
                    errors += "<br/>";
                }

                TempData["Message"] = ToastrNotification.Show(errors, position: Position.BottomRight,
                    type: ToastType.error);

                return RedirectToRoute(new
                {
                    controller = "Blog",
                    action = "GetAll",
                });

            }

            NewsLetter newEntity = _mapper.Map(viewModel, new NewsLetter());

            _newsLetterService.Add(newEntity);

            TempData["Message"] = ToastrNotification.Show(_stringLocalizer["SubscribedSuccessfully"], position: Position.BottomRight,
                type: ToastType.success);

            return RedirectToRoute(new
            {
                controller = "Blog",
                action = "GetAll",
            });
        }

    }
}
