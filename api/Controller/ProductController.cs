using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace api.Controller;

[Authorize]
[ApiController]
[Route("api/[controller]")]
public class ProductController : ControllerBase
{
    [HttpGet("productcreate")]
    public IActionResult create()
    {
        return Ok(new
        {
            Id = User.FindFirst("id")?.Value,
            Username = User.Identity?.Name,
            Email = User.FindFirst(ClaimTypes.Email)?.Value
        });
    }

}
