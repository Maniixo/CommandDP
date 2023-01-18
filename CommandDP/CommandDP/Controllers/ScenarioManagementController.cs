using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace CommandDP.Controllers
{
    [Route("ScenarioManagementController")]
    [ApiController]
    public class ScenarioManagementController : ControllerBase
    {

        [HttpPost]
        [EnableCors]
        public ScenarioResponseBase Execute([FromBody] ScenarioBase scenario)
        {
            int x = 50;
            ScenarioResponseBase bigResult = scenario.Execute();

            return bigResult;
        }
        [HttpGet]
        [EnableCors]
        [Route("monitor")]
        public string monitor()
        {
            return "It works";
        }
    }
}
