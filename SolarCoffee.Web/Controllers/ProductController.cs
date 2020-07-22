using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SolarCoffee.Data.Models;
using SolarCoffee.Services.Product;
using SolarCoffee.Web.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolarCoffee.Web.Controllers
{
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;
        private readonly IProductService _productService;

        public ProductController(ILogger<ProductController> logger, IProductService productService)
        {
            _logger = logger;
            _productService = productService;
        }

        [HttpGet("/api/products")]
        public ActionResult GetProduct()
        {
            _logger.LogInformation("Getting All Products");
            var products = _productService.GetAllProducts();

            var productViewModels = products.Select(ProductMapper.SerializeProductModel);

            return Ok(productViewModels);
        }
    }
}
