using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace com.example.dotnetcore.webapi.Controllers
{
    [ApiVersion( "1.0" )]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class ClaimsController : ControllerBase
    {
        // GET api/v1.0/Claims
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {

            //return new JsonResult(new string[] { "value1", "value2" });
            return Ok(new string[] { "value1", "value2" });
        }

        // GET api/v1.0/Claims/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            var result = new JsonResult(string.Format("value:{0}",id));
            result.StatusCode =200;
            result.ContentType = "text/plain";
            return result;
        }

        // POST api/v1.0/Claims
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/v1.0/Claims/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/v1.0/Claims/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
