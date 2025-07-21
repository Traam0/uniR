using Microsoft.AspNetCore.Mvc;

namespace UniR.WebAPI.Controllers;

[ApiController]
[Route("v1/[controller]")]
public class GroupsController : ControllerBase
{
    [HttpGet()]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    public IActionResult Get([FromHeader] string apiKey,[FromQuery] string groupName, uint pageNumber = 1, uint pageSize = 5)
    {
        return StatusCode(StatusCodes.Status401Unauthorized);
    }

    [HttpGet("{id:guid}")]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    public IActionResult Find(Guid id, [FromHeader] string apiKey)
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

    [HttpGet("{id:guid}/students")]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    public IActionResult GetGroupStudents(Guid id, [FromHeader] string apiKey)
    {
        return StatusCode(StatusCodes.Status401Unauthorized);
    }

    [HttpGet("{id:guid}/teachers")]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    public IActionResult GetGroupTeachers(Guid id, [FromHeader] string apiKey)
    {
        return StatusCode(StatusCodes.Status401Unauthorized);
    }
}