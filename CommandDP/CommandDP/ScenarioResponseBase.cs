using System.Net;

namespace CommandDP
{
    public class ScenarioResponseBase
    {
        public string ErrorMessage { get; set; }

        public Exception Exception { get; set; }
        public HttpStatusCode StatusCode { get; set; }

        public string? Content { get; set; }
    }
}
