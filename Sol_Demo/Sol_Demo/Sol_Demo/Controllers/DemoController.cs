using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol_Demo.Controllers
{
    [Produces("application/json")]
    [Route("api/demo")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        // Read Data from Query Template
        //http://localhost:60186/api/demo/example1/id/1/name/kishor
        [HttpGet("example1/id/{id:int}/name/{name}")]
        public IActionResult Example1(int id, string name)
        {
            return base.Ok(new
            {
                id = id,
                name = name
            });
        }

        // Read Data from Query String by using From Query Attribute
        //http://localhost:60186/api/demo/example2?id=1&name=kishor
        [HttpGet("example2")]
        public IActionResult Example2([FromQuery] int id, [FromQuery] string name)
        {
            return base.Ok(new
            {
                id = id,
                name = name
            });
        }

        // Read Header Value
        //http://localhost:60186/api/demo/example3
        [HttpGet("example3")]
        public IActionResult Example3([FromHeader] int id, [FromHeader] string name)
        {
            return base.Ok(new
            {
                id = id,
                name = name
            });
        }
    }
}