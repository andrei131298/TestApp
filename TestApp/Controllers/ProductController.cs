using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApp.Controllers
{
    //[Route("[controller]")]
    [Route("product")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        // GET: /product
        [HttpGet]
        public string Get()
        {
            return "corect";
        }

        public ProductController() { }
    }
}
