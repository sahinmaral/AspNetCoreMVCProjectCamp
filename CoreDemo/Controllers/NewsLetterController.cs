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
    public class NewsLetterController : Controller
    {

        private readonly INewsLetterService _newsLetterService;
        private readonly IMapper _mapper;
        public NewsLetterController(INewsLetterService newsLetterService, IMapper mapper)
        {
            _newsLetterService = newsLetterService;
            _mapper = mapper;
        }
        

        [HttpPost]
        public IActionResult SubscribeEmailAtBlog(CreateNewsLetterViewModel viewModel)
        {
            NewsLetter searchedNewsLetter = _newsLetterService.Get(x => x.NewsLetterMail == viewModel.Email);

            if (searchedNewsLetter != null)
            {
                TempData["Message"] = Notification.Show("Böyle bir email zaten abone olmuş.", position: Position.BottomRight, type: ToastType.error);

                return RedirectToRoute(new
                {
                    controller = "Blog",
                    action = "GetById",
                    blogId = TempData["BlogId"]
                });
            }

            searchedNewsLetter = _mapper.Map(viewModel, searchedNewsLetter);

            _newsLetterService.Add(searchedNewsLetter);

            TempData["Message"] = Notification.Show("Başarıyla abone oldunuz.", position:Position.BottomRight , type:ToastType.success);

                return RedirectToRoute(new
                {
                    controller = "Blog",
                    action = "GetById",
                    blogId = TempData["BlogId"]
                });
        }

        [HttpPost]
        public IActionResult SubscribeEmailAtAbout(CreateNewsLetterViewModel viewModel)
        {
            NewsLetter searchedNewsLetter = _newsLetterService.Get(x => x.NewsLetterMail == viewModel.Email);

            if (searchedNewsLetter != null)
            {
                TempData["Message"] = Notification.Show("Böyle bir email zaten abone olmuş.", position: Position.BottomRight, type: ToastType.error);

                return RedirectToRoute(new
                {
                    controller = "About",
                    action = "Index"
                });
            }

            searchedNewsLetter = _mapper.Map(viewModel, searchedNewsLetter);

            _newsLetterService.Add(searchedNewsLetter);

            TempData["Message"] = Notification.Show("Başarıyla abone oldunuz.", position: Position.BottomRight, type: ToastType.success);

            return RedirectToRoute(new
            {
                controller = "About",
                action = "Index"
            });
        }

        public IActionResult SubscribeEmailAtFooter()
        {
            throw new System.NotImplementedException();
        }
    }
}
