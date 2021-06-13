using MyWebServer.Http;

namespace MyWebServer.Results
{
    public class BadRequestResult : HttpResponse
    {
        public BadRequestResult()
            : base(HttpStatusCode.BadRequest)
        {
        }
    }
}
