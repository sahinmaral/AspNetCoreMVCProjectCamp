using AutoMapper;
using Business.Abstract;
using ClosedXML.Excel;
using CoreDemo.Models;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;
using X.PagedList;

namespace CoreDemo.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public CategoryController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }
        public IActionResult GetCategories(int page = 1)
        {
            
            List<ReadCategoryViewModel> viewModels = new List<ReadCategoryViewModel>();

            viewModels = _mapper.Map(_categoryService.GetAll(), viewModels);

            return View(viewModels.ToPagedList(page, 5));
        }

        [HttpGet]
        public IActionResult AddCategory()
        {
            return View(new CreateCategoryViewModel());
        }

        [HttpPost]
        public IActionResult AddCategory(CreateCategoryViewModel viewModel)
        {
            if (!ModelState.IsValid)
                return View(viewModel);

            Category category = new Category();
            category = _mapper.Map(viewModel, category);

            _categoryService.Add(category);

            return RedirectToAction("GetCategories", "Category");
        }

        [HttpGet]
        public IActionResult UpdateCategory(int id)
        {
            return View(_mapper.Map(_categoryService.Get(x=>x.CategoryId == id),new ReadCategoryViewModel()));
        }

        [HttpPost]
        public IActionResult UpdateCategory(ReadCategoryViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }

            Category category = _mapper.Map(viewModel, new Category());
            _categoryService.Update(category);

            return RedirectToAction("GetCategories");
        }

        [HttpGet]
        public IActionResult DisableCategory(int id)
        {
            Category category = _categoryService.Get(x => x.CategoryId == id);
            category.CategoryStatus = false;

            _categoryService.Update(category);

            return RedirectToAction("GetCategories");
        }

        [HttpGet]
        public IActionResult EnableCategory(int id)
        {
            Category category = _categoryService.Get(x => x.CategoryId == id);
            category.CategoryStatus = true;

            _categoryService.Update(category);

            return RedirectToAction("GetCategories");
        }

        public IActionResult ExportStaticExcelCategories()
        {
            using var workBook = new XLWorkbook();

            var worksheet = workBook.Worksheets.Add("Kategori Listesi");
            worksheet.Cell(1, 1).Value = "Kategori Id";
            worksheet.Cell(1, 2).Value = "Kategori Adı";
            worksheet.Cell(1, 3).Value = "Kategori Açıklaması";
            worksheet.Cell(1, 4).Value = "Kategori Durumu";

            int count = 2;
            List<Category> categories = _categoryService.GetAll();

            foreach (Category category in categories)
            {
                worksheet.Cell(count, 1).Value = category.CategoryId;
                worksheet.Cell(count, 2).Value = category.CategoryName;
                worksheet.Cell(count, 3).Value = category.CategoryDescription;
                worksheet.Cell(count, 4).Value = category.CategoryStatus;

                count++;
            }

            string fileName = "Kategori Listesi " + ".xlsx";

            using var stream = new MemoryStream();

            workBook.SaveAs(stream);
            var content = stream.ToArray();
            return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",fileName);
        }
    }
}
