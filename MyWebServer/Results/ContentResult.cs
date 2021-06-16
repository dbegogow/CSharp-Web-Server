using MyWebServer.Http;

namespace MyWebServer.Results
{
    public class ContentResult : ActionResult
    {
        public ContentResult(
            HttpResponse response,
            string content,
            string contentType)
            : base(response)
            => this.SetContent(content, contentType);
    }
}
