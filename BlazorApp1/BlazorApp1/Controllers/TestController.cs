using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BlazorApp1.Controllers;

[Authorize(Roles = "Admin")]
[Route("api/[controller]")]
[ApiController]
public class TestController : ControllerBase
{
    [HttpGet(Name = "GetGradovi")]
    public  IActionResult GetGradovi()
    {
        return Ok(new List<string>
        {
            "jasmin",
            "je",
            "uspio"
        });
    }
}