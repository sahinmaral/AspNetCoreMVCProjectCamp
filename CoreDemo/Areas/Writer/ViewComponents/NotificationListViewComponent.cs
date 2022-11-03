using AutoMapper;
using Business.Abstract;
using CoreDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

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

            viewModels = _mapper.Map(_notificationService.GetAllWithDetails(x => x.Status).OrderByDescending(x => x.CreatedAt).Take(3).ToList(),viewModels); 

            return View(viewModels);
        }
    }
}
