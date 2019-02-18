using Microsoft.AspNetCore.Mvc;

namespace Actio.Api.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult get() => Content("Hello from Action API!");
    }
}