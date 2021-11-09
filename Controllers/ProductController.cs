using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace demoSwaggerAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : Controller
    {
        [HttpGet]
        public Product Get()
        {
            return new Product
            {
                IdProduct = 123,
                NameProduct = "Microchip-A",
                PriveProduct = 30
            };
        }

        [HttpGet("GetProduct")]
        public IEnumerable<Product> GetProducts()
        {
            return new List<Product>();
        }

        [HttpPost]
        public Product CreateNewProduct([FromBody] Product product)
        {
            // product.IdProduct = 999;

            return product;
        }

        [HttpPut]
        public string ChangeProduct([FromBody] Product product)
        {
            return "Product has been changed";
        }
    }
}
