using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace FinSpect.Api.Controllers.v1;

[ApiController]
[ApiVersion(1.0)]
[Route( "api/v{version:apiVersion}/[controller]" )]
public class TransactionsController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok();
    }
}