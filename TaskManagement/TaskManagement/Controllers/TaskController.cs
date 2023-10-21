using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TaskManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        [HttpGet ("Getpath")]
        public IActionResult GetPaths(string id)
        {
            return Ok(new { id });
        }
    }
}
