using Microsoft.AspNetCore.Mvc;
using MVC.Service;
using MVC.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Web.Controllers
{
    public class CategoryController : Controller
    {
        //creating an instance of the ICategory service
        //passing to the constructor
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            List<CategoryViewModel> model = new List<CategoryViewModel>();
            _categoryService.GetAllCategories().ToList().ForEach(u =>
            {
                _categoryService.GetCategoryById(u.Id);
                CategoryViewModel cvm = new CategoryViewModel
                {
                    Id = u.Id,
                    Name = u.Name,
                    DisplayOrder = u.DisplayOrder
                };
                model.Add(cvm);
            });
            return View(model);
        }   
    }
}
