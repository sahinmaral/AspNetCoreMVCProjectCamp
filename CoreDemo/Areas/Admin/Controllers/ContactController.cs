using AutoMapper;
using Business.Abstract;
using CoreDemo.Areas.Admin.Models;
using CoreDemo.Models;
using DocumentFormat.OpenXml.Office2010.ExcelAc;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Net.Mail;
using System.Net;
using Core.Helper.Toastr.OptionEnums;
using Core.Helper.Toastr;

namespace CoreDemo.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;
        private readonly IMapper _mapper;
        

        public ContactController(IContactService contactService, IMapper mapper)
        {
            _contactService = contactService;
            _mapper = mapper;
        }
        public IActionResult GetContacts()
        {
            List<ReadContactViewModel> viewModels = _mapper.Map(_contactService.GetAll(), new List<ReadContactViewModel>());

            return View(viewModels);
        }

        public IActionResult GetContactDetail(int id)
        {
            Contact foundContact = _contactService.Get(x => x.Id == id);

            ReadContactViewModel viewModel = _mapper.Map(foundContact,new ReadContactViewModel());

            foundContact.IsOpened = true;

            _contactService.Update(foundContact);

            return View(viewModel);
        }

        
        public IActionResult RespondContactedUser(int id)
        {
            RespondContactedUserViewModel viewModel = _mapper.Map(_contactService.Get(x => x.Id == id), new RespondContactedUserViewModel());
            viewModel.Subject = string.Empty;
            viewModel.Message = string.Empty;

            return View(viewModel);
        }

        public EmailServiceConfigurationModel AssignEmailConfigurationAndReturn()
        {
            using (StreamReader r = new StreamReader(Directory.GetCurrentDirectory() + "/Constants/mailServiceConfiguration.json"))
            {
                string json = r.ReadToEnd();
                EmailServiceConfigurationModel config = JsonConvert.DeserializeObject<EmailServiceConfigurationModel>(json);
                return config;
            }
        }

        [HttpPost]
        public IActionResult RespondContactedUser(RespondContactedUserViewModel viewModel)
        {
            EmailServiceConfigurationModel config = AssignEmailConfigurationAndReturn();

            var smtpClient = new SmtpClient(config.Host)
            {
                Port = config.Port,
                Credentials = new NetworkCredential(config.Email, config.Password),
                EnableSsl = config.IsSSLEnabled,
            };

            MailMessage message = new MailMessage();
            message.From = new MailAddress(config.Email, "Şahin MARAL");
            message.To.Add(viewModel.Email);
            message.Subject = viewModel.Subject;
            message.IsBodyHtml = true;
            message.Body = viewModel.Message;

            try
            {
                smtpClient.Send(message);
            }
            catch (System.Exception)
            {
                TempData["Message"] = ToastrNotification.Show("There has been an error during sending message to the person", position: Position.BottomRight,
                type: ToastType.error);
                return RedirectToAction(nameof(GetContacts));
            }
            

            Contact updatedContact = _contactService.Get(x => x.Id == viewModel.Id);
            updatedContact.IsAnswered = true;

            _contactService.Update(updatedContact);

            TempData["Message"] = ToastrNotification.Show("Message has been sent to the person that contacted us", position: Position.BottomRight,
            type: ToastType.success);

            return RedirectToAction(nameof(GetContacts));
        }
    }
}
