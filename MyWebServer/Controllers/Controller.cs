using MyWebServer.Http;
using MyWebServer.Responses;
using System.Runtime.CompilerServices;

namespace MyWebServer.Controllers
{
    public abstract class Controller
    {
        protected Controller(HttpRequest request)
            => this.Request = request;

        protected HttpRequest Request { get; private init; }

        protected HttpResponse Text(string text)
            => new TextResponse(text);

        protected HttpResponse Html(string html)
            => new HtmlResponse(html);

        protected HttpResponse Redirect(string location)
            => new RedirectResponse(location);

        protected HttpResponse View([CallerMemberName] string viewName = "")
            => new ViewResponse(viewName, this.GetControllerName());

        private string GetControllerName()
            => this.GetType().Name.
                Replace(nameof(Controller), string.Empty);
    }
}
