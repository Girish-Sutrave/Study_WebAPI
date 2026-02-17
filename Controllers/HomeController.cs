using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllEmployees()
        {
            var employees = new List<string>
            {
                "John Doe",
                "Jane Smith",
                "Bob Johnson"
            };
            return Ok(employees);
        }
    }
}
