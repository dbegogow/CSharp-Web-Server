using MyWebServer.Http;

namespace MyWebServer.Responses
{
    public class TextResponse : ContentResponse
    {
        public TextResponse(string text)
            : base(text, HttpContentType.PlainText)
        {
        }
    }
}
