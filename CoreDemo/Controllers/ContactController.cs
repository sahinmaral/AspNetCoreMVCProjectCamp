using AutoMapper;

using Business.Abstract;
using Core.Helper.Toastr;
using Core.Helper.Toastr.OptionEnums;
using CoreDemo.Models;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    [AllowAnonymous]
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;
        private readonly IAboutService _aboutService;
        private readonly IMapper _mapper;
        public ContactController(IContactService contactService, IMapper mapper, IAboutService aboutService)
        {
            _contactService = contactService;
            _mapper = mapper;
            _aboutService = aboutService;
        }

        public IActionResult Index()
        {
            TempData["MapLocation"] = _aboutService.Get(x => x.AboutStatus == true).AboutMapLocation;

            return View();
        }

        [HttpPost]
        public IActionResult AddContact(CreateContactViewModel viewModel)
        {
            //TODO : Spam engellemek için süre konulabilir 

            Contact contact = new Contact();

            contact = _mapper.Map(viewModel, contact);

            _contactService.Add(contact);

            TempData["Message"] = ToastrNotification.Show("Mesajınız başarılı bir şekilde yollandı.", position: Position.BottomRight, type: ToastType.success);

            return RedirectToAction("Index");
        }
    }
}
