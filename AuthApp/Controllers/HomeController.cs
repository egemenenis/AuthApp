using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AuthApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        [Authorize]
        public IActionResult GetHome()
        {
            return Ok("Welcome to the Home Page!");
        }
    }

}
