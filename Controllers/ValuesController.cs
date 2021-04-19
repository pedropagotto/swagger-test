using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace webapi_swagger.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ValuesController : ControllerBase
    {
        // POST api/<ValuesController>
        [HttpPost]
        [ProducesResponseType(typeof(UnauthorizedResult), 401)]
        [ProducesResponseType(typeof(ForbidResult), 403)]
        [ProducesResponseType(typeof(List<ListParam>), 200)]
        [ProducesResponseType(typeof(ProblemDetails), 400)]
        [ProducesResponseType(typeof(ProblemDetails), 404)]
        [ProducesResponseType(typeof(ProblemDetails), 409)]
        public ActionResult<List<ListParam>> Post([FromBody] ListParam request)
        {
            var response = new List<ListParam>();
            response.Add(request);
            return response;
        }
    }
}
