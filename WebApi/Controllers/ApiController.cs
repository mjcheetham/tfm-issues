using System;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    public class ApiController : ControllerBase
    {
        [HttpGet]
        [Route("api/status")]
        public ActionResult GetStatus() => new OkObjectResult(new {uptime = Environment.TickCount64});
    }
}
