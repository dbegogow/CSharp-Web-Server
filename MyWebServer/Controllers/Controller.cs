using MyWebServer.Http;
using MyWebServer.Responses;

namespace MyWebServer.Controllers
{
    public abstract class Controller
    {
        protected Controller(HttpRequest request)
            => this.Request = request;

        protected HttpRequest Request { get; private init; }

        protected HttpResponse Text(string text)
            => new TextResponse(text);

        protected HtmlResponse Html(string html)
            => new HtmlResponse(html);
    }
}
