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
        [HttpPost("Posting")]
        public IActionResult AddCategory(Category category)
        {
            return Ok(CategoryBusiness.AddCategory(category));
        }
        [HttpPost]
        public IActionResult UploadImage([FromForm] IFormFile image)
        {
            if (image != null && image.Length > 0)
            {
                // Save the image to a desired location
                var uploads = Path.Combine("uploads"); // You can specify your desired path
                if (!Directory.Exists(uploads))
                {
                    Directory.CreateDirectory(uploads);
                }

                var filePath = Path.Combine(uploads, image.FileName);
                using var fileStream = new FileStream(filePath, FileMode.Create);
                image.CopyTo(fileStream);

                return Ok(new { FilePath = filePath });
            }

            return BadRequest("Invalid image file.");
        }
    }
}
