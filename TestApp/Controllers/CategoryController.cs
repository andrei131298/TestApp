using Microsoft.AspNetCore.Mvc;
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
