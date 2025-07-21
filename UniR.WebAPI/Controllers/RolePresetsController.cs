using Microsoft.AspNetCore.Mvc;
using UniR.Contracts.Dto.Roles;

namespace UniR.WebAPI.Controllers;

[ApiController]
[Route("v1/role-presets")]
public class RolePresetsController : ControllerBase
{
    [HttpGet()]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    public IActionResult GetAllPresets([FromHeader] string apiKey)
    {
        return StatusCode(StatusCodes.Status401Unauthorized);
    }

    [HttpGet("{id:int}")]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    public IActionResult GetPreset(uint id, [FromHeader] string apiKey)
    {
        return StatusCode(StatusCodes.Status401Unauthorized);
    }

    [HttpPost()]
    public IActionResult CreatePreset([FromBody] RolePresetBriefDto preset, [FromHeader] string apiKey)
    {
        return StatusCode(StatusCodes.Status401Unauthorized);
    }

    [HttpPatch("{id:int}/permissions")]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    public IActionResult AddPermissions(uint id, IEnumerable<string> permissions, [FromHeader] string apiKey)
    {
        return StatusCode(StatusCodes.Status401Unauthorized);
    }

    [HttpDelete("{id:int}")]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    public IActionResult DeletePreset(uint id, [FromHeader] string apiKey)
    {
        return StatusCode(StatusCodes.Status401Unauthorized);
    }
}
