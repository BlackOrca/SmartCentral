using Microsoft.AspNetCore.Mvc;
using SmartCentral.Filters;

namespace SmartCentral.Controllers.V1
{
    [ApiKeyAuth]
    public class SecretController : ControllerBase
    {
        [HttpGet("secret")]
        public IActionResult GetSecret()
        {
            return Ok("I have no secrets");
        }
    }
}