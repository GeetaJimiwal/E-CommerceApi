using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly ILogger<ProductsController> _logger;

        public ProductsController(ILogger<ProductsController> logger)
        {
            _logger = logger;
        }

        

        [HttpGet]


        public IEnumerable<Products> Get()
        {

            ProductData productData = new();
            var result = productData.GetProducts();
            return result;
        }
    }
}


