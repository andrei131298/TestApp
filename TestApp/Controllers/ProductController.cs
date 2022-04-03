using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApp.IServices;
using TestApp.Models;
using TestApp.Services;

namespace TestApp.Controllers
{
    //[Route("[controller]")]
    [Route("product")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService) {
            _productService = productService;
        }

        // GET: /product
        [HttpGet]
        public List<Product> GetAll()
        {
            var allProducts = _productService.GetAll();
            return allProducts;
        }

        [HttpGet("{id}")]
        public Product GetById(Guid id)
        {
            return _productService.GetById(id);
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            var allProducts = _productService.Create(product);

            if (allProducts == null)
                return StatusCode(500);

            return Ok(allProducts);
        }

    }
}
