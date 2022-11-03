using AutoMapper;
using Business.Abstract;
using CoreDemo.Models;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using X.PagedList;

namespace CoreDemo.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class NotificationController : Controller
    {
        private readonly INotificationService _notificationService;
        private readonly INotificationTypeService _notificationTypeService;
        private readonly INotificationSymbolService _notificationSymbolService;
        private readonly ILanguageService _languageService;
        private readonly INotificationInformationService _notificationInformationService;
        private readonly IMapper _mapper;
        public NotificationController(INotificationService notificationService, IMapper mapper, INotificationTypeService notificationTypeService, INotificationSymbolService notificationSymbolService, ILanguageService languageService, INotificationInformationService notificationInformationService)
        {
            _notificationService = notificationService;
            _mapper = mapper;
            _notificationTypeService = notificationTypeService;
            _notificationSymbolService = notificationSymbolService;
            _languageService = languageService;
            _notificationInformationService = notificationInformationService;
        }
        public IActionResult GetNotifications(int page=1)
        {
            List<ReadNotificationViewModel> viewModels = _mapper.Map(_notificationService.GetAllWithDetails(), new List<ReadNotificationViewModel>());

            CultureInfo currentCultureInfo = Thread.CurrentThread.CurrentCulture;

            foreach (var viewModel in viewModels)
            {
                foreach (var notificationInformation in viewModel.NotificationInformations)
                {
                    if (notificationInformation.Language.ShortName != currentCultureInfo.Name)
                    {
                        viewModel.NotificationInformations.Remove(notificationInformation);
                        break;
                    }
                }
            }

            return View(viewModels.ToPagedList(page, 5));
        }

        private void GetNotificationSelectListItems()
        {
            ViewData["NotificationTypes"] = (from x in _notificationTypeService.GetAll()
                                                   select new SelectListItem()
                                                   {
                                                       Text = x.Name,
                                                       Value = x.Id.ToString()
                                                   }).ToList();

            ViewData["NotificationSymbols"] = (from x in _notificationSymbolService.GetAll()
                                             select new SelectListItem()
                                             {
                                                 Text = x.Name,
                                                 Value = x.Id.ToString()
                                             }).ToList();

            ViewData["Languages"] = _mapper.Map(_languageService.GetAll(), new List<ReadLanguageViewModel>());

        }


        [HttpGet]
        public IActionResult AddNotification()
        {
            GetNotificationSelectListItems();

            CreateNotificationViewModel viewModel = new CreateNotificationViewModel();
            viewModel.NotificationInformations = new List<NotificationInformation>();

            var languages = ViewData["Languages"] as List<ReadLanguageViewModel>;
            foreach (var language in languages)
            {
                NotificationInformation notificationInformation = new NotificationInformation();
                notificationInformation.Language = new Language();
                viewModel.NotificationInformations.Add(notificationInformation);
            }

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult AddNotification(CreateNotificationViewModel viewModel)
        {
            Notification newNotification = new Notification();
            newNotification.NotificationSymbolId = viewModel.NotificationSymbol.Id;
            newNotification.NotificationTypeId = viewModel.NotificationType.Id;

            _notificationService.Add(newNotification);

            foreach (var notificationInformation in viewModel.NotificationInformations)
            {
                notificationInformation.LanguageId = _languageService.Get(x => x.ShortName == notificationInformation.Language.ShortName).Id;
                notificationInformation.NotificationId = newNotification.Id;
                _notificationInformationService.Add(notificationInformation);
            }

            return RedirectToAction(nameof(GetNotifications));
        }

        [HttpGet]
        public IActionResult UpdateNotification(int id)
        {
            GetNotificationSelectListItems();

            ReadNotificationViewModel viewModel = _mapper.Map(_notificationService.GetByIdWithDetails(id),new ReadNotificationViewModel());

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult UpdateNotification(ReadNotificationViewModel viewModel)
        {
            Notification updatedNotification = _notificationService.GetByIdWithDetails(viewModel.Id);

            updatedNotification.NotificationTypeId = _notificationTypeService.Get(x => x.Id == viewModel.NotificationType.Id).Id;
            updatedNotification.NotificationSymbolId = _notificationSymbolService.Get(x => x.Id == viewModel.NotificationSymbol.Id).Id;

            foreach (var notificationInformation in viewModel.NotificationInformations)
            {
                foreach (var updatedNotificationInformation in updatedNotification.NotificationInformations)
                {
                    if(updatedNotificationInformation.Id == notificationInformation.Id)
                    {
                        updatedNotificationInformation.Header = notificationInformation.Header;
                        updatedNotificationInformation.Detail = notificationInformation.Detail;
                        _notificationInformationService.Update(updatedNotificationInformation);
                        break;
                    }
                }
            }

            _notificationService.Update(updatedNotification);

            return RedirectToAction(nameof(GetNotifications));
        }

        public IActionResult DeleteNotification(int id)
        {
            _notificationService.Delete(_notificationService.Get(x => x.Id == id));

            return RedirectToAction(nameof(GetNotifications));
        }
    }
}
