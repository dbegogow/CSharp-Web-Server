using MyWebServer.Http;

namespace MyWebServer.Results
{
    public class HtmlResult : ContentResult
    {
        public HtmlResult(HttpResponse response, string html)
            : base(response, html, HttpContentType.Html)
        {
        }
    }
}
