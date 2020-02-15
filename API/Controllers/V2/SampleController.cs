using System.Collections.Generic;
using Logic.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.V2
{
    /// <summary>
    ///     Sample Controller
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    [ApiVersion("2.0")]
    public class SampleController : Controller
    {
        private readonly IExample _example;

        public SampleController(IExample example)
        {
            _example = example;
        }

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
            return Ok(_example.ExampleMethod());
        }
    }
}