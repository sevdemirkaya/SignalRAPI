using Microsoft.AspNetCore.Mvc;
using SignalR.DtoLayer.AboutDTO;


namespace SignalRWebUI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AboutController : ControllerBase
    {
        // CREATE
        [HttpPost("create")]
        public IActionResult CreateAbout([FromBody] CreateAboutDto dto)
        {
            return Ok("Hakkımda bilgisi eklendi.");
        }

        // READ
        [HttpGet("get")]
        public IActionResult GetAbout()
        {
            return Ok("Hakkımda bilgisi.");
        }

        // UPDATE
        [HttpPut("update")]
        public IActionResult UpdateAbout([FromBody] GetAboutDto dto)
        {
            return Ok("Hakkımda bilgisi güncellendi.");
        }

        // DELETE
        [HttpDelete("delete/{id}")]
        public IActionResult DeleteAbout(int id)
        {
            return Ok($"ID {id} olan hakkımda bilgisi silindi.");
        }
    }
}
