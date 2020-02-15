using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.V1
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiVersion("1.0")]
    public class SampleController : Controller
    {
        /// <summary>
        ///     A sample controller route
        /// </summary>
        /// <param name="portfolioPolicy"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("")]
        [ProducesResponseType(200)]
        public IActionResult ExampleGet([FromQuery] List<string> portfolioPolicy)
        {
            return Ok();
        }
    }
}