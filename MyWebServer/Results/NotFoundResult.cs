using MyWebServer.Http;

namespace MyWebServer.Results
{
    public class NotFoundResult : ActionResult
    {
        public NotFoundResult(HttpResponse response)
            : base(response)
            => this.StatusCode = HttpStatusCode.NotFound;
    }
}
