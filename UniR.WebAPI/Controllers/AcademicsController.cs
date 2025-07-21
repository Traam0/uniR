using Microsoft.AspNetCore.Mvc;

namespace UniR.WebAPI.Controllers;

[ApiController]
[Route("v1/[controller]")]
public class AcademicsController : ControllerBase
{
    [HttpGet()]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    public IActionResult All([FromHeader] string apiKey)
    {
        return StatusCode(StatusCodes.Status401Unauthorized);
    }

    [HttpGet("{id:int}")]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    public IActionResult Find(uint id, [FromHeader] string apiKey)
    {
        return StatusCode(StatusCodes.Status401Unauthorized);
    }

    [HttpPost()]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    public IActionResult Create([FromBody] object body, [FromHeader] string apiKey)
    {
        return StatusCode(StatusCodes.Status401Unauthorized);
    }

    [HttpPut("{id:int}")]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    public IActionResult Update(uint id, [FromBody] object body, [FromHeader] string apiKey)
    {
        return StatusCode(StatusCodes.Status401Unauthorized);
    }

    [HttpDelete("{id:int}")]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    public IActionResult Delete(uint id, [FromHeader] string apiKey)
    {
        return StatusCode(StatusCodes.Status401Unauthorized);
    }

    [HttpGet("branches/{id:int}")]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    public IActionResult FindBranch(uint id, [FromHeader] string apiKey)
    {
        return StatusCode(StatusCodes.Status401Unauthorized);
    }

    [HttpPost("branches")]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    public IActionResult CreateBranch([FromBody] object body, [FromHeader] string apiKey)
    {
        return StatusCode(StatusCodes.Status401Unauthorized);
    }

    [HttpPatch("branches/{id:int}")]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    public IActionResult PatchBranch(uint id, [FromBody] object body, [FromHeader] string apiKey)
    {
        return StatusCode(StatusCodes.Status401Unauthorized);
    }

    [HttpDelete("branches/{id:int}")]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    public IActionResult DeleteBranch(uint id, [FromHeader] string apiKey)
    {
        return StatusCode(StatusCodes.Status401Unauthorized);
    }
}