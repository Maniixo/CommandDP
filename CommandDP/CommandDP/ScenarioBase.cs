using Newtonsoft.Json;

namespace CommandDP
{
    [JsonConverter(typeof(ScenarioBaseConverter))]
    public class ScenarioBase
    {
        public string typename { get; set; }
        public virtual ScenarioResponseBase Execute()
        {
            return new ScenarioResponseBase();
        }

    }
}
