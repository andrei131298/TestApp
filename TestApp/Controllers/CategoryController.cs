using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TestApp.IServices;
using TestApp.Models;

namespace TestApp.Controllers
{
    [Route("category")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public ActionResult<List<Category>> GetAll()
        {
            var allCategories = _categoryService.GetAll();

            if (allCategories == null)
                return StatusCode(500);

            return Ok(allCategories);
        }

        [HttpPost]
        public IActionResult Create(Category category)
        {
            var allCategories = _categoryService.Create(category);

            if (allCategories == null)
                return StatusCode(500);

            return Ok(allCategories);
        }

    }
}
