using Microsoft.AspNetCore.Mvc;

namespace SignalRWebUI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetMessage()
        {
            return Ok("Swagger artık çalışıyor ablacım 🎉");
        }
    }
}