using Microsoft.AspNetCore.Mvc;

namespace UniR.WebAPI.Controllers;

[ApiController]
[Route("v1")]
public class IndexController : ControllerBase
{
    [HttpGet("ping")]
    public IActionResult Get()
    {
        return StatusCode(StatusCodes.Status200OK, "Pong!");
    }
}