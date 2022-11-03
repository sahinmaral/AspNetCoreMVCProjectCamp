using AutoMapper;

using Business.Abstract;
using Core.Helper.Toastr;
using Core.Helper.Toastr.OptionEnums;
using CoreDemo.Models;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace CoreDemo.Controllers
{
    [AllowAnonymous]
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;
        private readonly IAboutService _aboutService;
        private readonly IMapper _mapper;
        private readonly IStringLocalizer<ContactController> _localizer;
        public ContactController(IContactService contactService, IMapper mapper, IAboutService aboutService, IStringLocalizer<ContactController> localizer)
        {
            _contactService = contactService;
            _mapper = mapper;
            _aboutService = aboutService;
            _localizer = localizer;
        }

        public IActionResult Index()
        {
            TempData["MapLocation"] = _aboutService.Get(x => x.Status == true).MapLocation;

            return View();
        }

        [HttpPost]
        public IActionResult AddContact(CreateContactViewModel viewModel)
        {

            Contact contact = new Contact();

            contact = _mapper.Map(viewModel, contact);

            _contactService.Add(contact);

            TempData["Message"] = ToastrNotification.Show(_localizer["SentSuccessfully"], position: Position.BottomRight, type: ToastType.success);

            return RedirectToAction("Index");
        }


    }
}
