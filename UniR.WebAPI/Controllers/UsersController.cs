using Microsoft.AspNetCore.Mvc;

namespace UniR.WebAPI.Controllers;

[ApiController]
[Route("v1/[controller]")]
public class UsersController : ControllerBase
{
    [HttpGet()]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    public IActionResult GetUsers([FromHeader] string apiKey, uint pageNumber = 1, uint pageSize = 5)
    {
        return StatusCode(StatusCodes.Status401Unauthorized);
    }

    [HttpGet("{id:guid}")]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    public IActionResult GetUser(Guid id, [FromHeader] string apiKey)
    {
        return StatusCode(StatusCodes.Status401Unauthorized);
    }

    [HttpPost()]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    public IActionResult CreateUser([FromBody] object body, [FromHeader] string apiKey)
    {
        return StatusCode(StatusCodes.Status401Unauthorized);
    }

    [HttpDelete("{id:guid}")]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    public IActionResult DeleteUser(Guid id, [FromHeader] string apiKey)
    {
        return StatusCode(StatusCodes.Status401Unauthorized);
    }

    [HttpPatch("{id:guid}")]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    public IActionResult UpdateUser(Guid id, [FromBody] object body, [FromHeader] string apiKey)
    {
        return StatusCode(StatusCodes.Status401Unauthorized);
    }

    [HttpPut("{id:guid}")]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    public IActionResult UpdateWholeUser(Guid id, [FromBody] object body, [FromHeader] string apiKey)
    {
        return StatusCode(StatusCodes.Status401Unauthorized);
    }

    [HttpPatch("{id:guid}/permissions")]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    public IActionResult CreatePreset(Guid id, [FromBody] IEnumerable<string> preset, [FromHeader] string apiKey)
    {
        return StatusCode(StatusCodes.Status401Unauthorized);
    }
}