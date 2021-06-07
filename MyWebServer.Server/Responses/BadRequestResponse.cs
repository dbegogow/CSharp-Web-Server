using MyWebServer.Server.Http;

namespace MyWebServer.Server.Responses
{
    public class BadRequestResponse : HttpResponse
    {
        public BadRequestResponse()
            : base(HttpStatusCode.BadRequest)
        {
        }
    }
}
