using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace JETCS_EMPTC_SRV.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmptcController : ControllerBase
    {
        private readonly ILogger<EmptcController> _logger;

        public EmptcController(ILogger<EmptcController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetData")]
        public JsonResult Get()
        {
            var data = new { Data = 1 };
            var result = new JsonResult(data)
            {
                ContentType = "application/json"                
            };
            result.StatusCode = (int)HttpStatusCode.OK;
            return result;
        }
    }
}
