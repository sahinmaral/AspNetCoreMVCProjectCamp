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
        public PartialViewResult SubscribeEmail(CreateNewsLetterViewModel viewModel)
        {
            NewsLetter newsLetter = new NewsLetter();
            newsLetter = _mapper.Map(viewModel, newsLetter);
            _newsLetterService.Add(newsLetter);

            return PartialView();
        }

    }
}
