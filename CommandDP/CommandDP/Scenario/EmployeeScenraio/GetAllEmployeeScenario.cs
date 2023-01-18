namespace CommandDP.Scenario.EmployeeScenraio
{
    public class GetAllEmployeeScenario : ScenarioBase
    {
        public GetAllEmployeeScenario()  { }

        public override ScenarioResponseBase Execute()
        {
            ScenarioResponseBase result = new ScenarioResponseBase();
            result.StatusCode = System.Net.HttpStatusCode.OK;
            result.Content = "GetAllEmployeeScenario WORKS !!";
            return result;
        }
    }
}
