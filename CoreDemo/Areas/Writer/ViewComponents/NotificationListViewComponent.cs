using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Business.Abstract;
using CoreDemo.Areas.Writer.Models;
using DocumentFormat.OpenXml.Office2010.ExcelAc;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Areas.Writer.ViewComponents
{
    public class NotificationListViewComponent : ViewComponent
    {
        private readonly INotificationService _notificationService;
        private readonly IMapper _mapper;

        public NotificationListViewComponent(INotificationService notificationService,IMapper mapper)
        {
            _notificationService = notificationService;
            _mapper = mapper;
        }
        public IViewComponentResult Invoke()
        {
            List<ReadNotificationViewModel> viewModels = new List<ReadNotificationViewModel>();

            viewModels = _mapper.Map(_notificationService.GetAllWithDetails(x => x.NotificationStatus).OrderByDescending(x => x.NotificationDate).Take(3).ToList(),viewModels); 

            return View(viewModels);
        }
    }
}
