using DatabaseAccessLayer.BusinessLogic;
using DatabaseAccessLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIWithControllers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ProductBusinessLogic _businessLogic;
        // Create a class constructor
        public ProductController (ProductBusinessLogic businessLogic)
        {
            _businessLogic = businessLogic;
        }
        [HttpGet("Retrieve")]
        public IActionResult GetProducts() 
        {
            return Ok(_businessLogic.GetProducts());
        }
        [HttpPost("Posting")]
        public IActionResult AddProducts(Product product) 
        {
            return Ok(_businessLogic.AddProduct(product));
        }
        [HttpPut("Updating")]
        public IActionResult UpdateProduct (Product product)
        {
            return Ok(_businessLogic.UpdateProduct(product));
        }
    }
}
