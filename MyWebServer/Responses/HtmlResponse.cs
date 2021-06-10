using MyWebServer.Http;

namespace MyWebServer.Responses
{
    public class HtmlResponse : ContentResponse
    {
        public HtmlResponse(string html)
            : base(html, HttpContentType.Html)
        {
        }
    }
}
