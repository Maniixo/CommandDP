namespace CommandDP.Scenario.EmployeeScenraio
{
    public class GetEmployeeByIdScenario : ScenarioBase
    {
        public int pId { get; set; }

        public GetEmployeeByIdScenario()
        {

        }
        public override ScenarioResponseBase Execute()
        {
            ScenarioResponseBase result = new ScenarioResponseBase();
            result.StatusCode = System.Net.HttpStatusCode.OK;
            result.Content = "GetEmployeeByIdScenario WORKS !!";
            return result;
        }
    }
}
