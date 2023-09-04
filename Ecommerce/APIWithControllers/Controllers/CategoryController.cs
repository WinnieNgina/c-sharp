using DatabaseAccessLayer.BusinessLogic;
using DatabaseAccessLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIWithControllers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly CategoryBusinessLogic CategoryBusiness;
        public CategoryController(CategoryBusinessLogic categotyBusiness)
        {
            CategoryBusiness = categotyBusiness;
        }
        [HttpGet("wamama")]
        public IActionResult GetCategory ()
        {
            return Ok(CategoryBusiness.GetCategories());
        }
        [HttpPost]
        public IActionResult AddCategory(Category category)
        {
            return Ok(CategoryBusiness.AddCategory(category));
        }
    }
}
