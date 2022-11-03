using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Business.Abstract;
using CoreDemo.Areas.Admin.Models;
using CoreDemo.Models;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;

namespace CoreDemo.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class ChartController : Controller
    {
        private readonly IBlogService _blogService;
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public ChartController(IBlogService blogService,ICategoryService categoryService,IMapper mapper)
        {
            _blogService = blogService;
            _categoryService = categoryService;
            _mapper = mapper;
        }

        public IActionResult CategoryChart()
        {
            return View();
        }

        public IActionResult CategoryChartJsonReturn()
        {
            List<CategoryChartViewModel> viewModels = new List<CategoryChartViewModel>();

            foreach (Category category in _categoryService.GetAll())
            {
                CategoryChartViewModel viewModel = new CategoryChartViewModel
                {
                    BlogCount = _blogService.GetAll(x => x.CategoryId == category.Id).Count,
                    CategoryName = category.Name
                };
                viewModels.Add(viewModel);
            }
            

            return Json(new { jsonList = viewModels});
        }
    }
}
