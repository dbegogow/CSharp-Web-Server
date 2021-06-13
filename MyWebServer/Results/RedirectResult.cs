using MyWebServer.Http;

namespace MyWebServer.Results
{
    public class RedirectResult : ActionResult
    {
        public RedirectResult(HttpResponse response, string location)
            : base(response)
        {
            this.StatusCode = HttpStatusCode.NotFound;

            this.AddHeader(HttpHeader.Location, location);
        }
    }
}
