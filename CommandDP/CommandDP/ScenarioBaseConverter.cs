using CommandDP.Scenario.EmployeeScenraio;
using Newtonsoft.Json.Linq;

namespace CommandDP
{
    public class ScenarioBaseConverter : JsonCreationConverter<object>
    {
        protected override object Create(Type objectType,
          Newtonsoft.Json.Linq.JObject jObject)
        {
            if (jObject.Value<string>("typename").Equals("GetEmployeeByIdScenario"))
            {
                return new GetEmployeeByIdScenario();
            }
            else if (jObject.Value<string>("typename").Equals("GetAllEmployeeScenario"))
            {
                return new GetAllEmployeeScenario();
            }
            else
            {
                return new GetAllEmployeeScenario();
            }
        
        }
    }
}
