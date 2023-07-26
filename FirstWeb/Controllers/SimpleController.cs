using Microsoft.AspNetCore.Mvc;

namespace FirstWeb.Controllers;

/// <summary>
/// Controller for Sample
/// </summary>
/// <response code="201">Returns the newly created item</response>
/// <response code="400">If the item is null</response>
[ApiController]
[Route("[controller]")]
[Produces("application/json")]
public class SimpleController : ControllerBase
{
    /// <summary>
    /// Simple API
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    [ProducesResponseType(typeof(string),200)]
    public IActionResult Index()
    {
        return Ok("Simple API");
    }
}