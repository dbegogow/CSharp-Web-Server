using MyWebServer.Http;

namespace MyWebServer.Controllers
{
    public class HttpGetAttribute : HttpMethodAttribute
    {
        public HttpGetAttribute()
            : base(HttpMethod.Get)
        {
        }
    }
}
