using System.Collections.Generic;

namespace MyWebServer.Server.Http
{
    public class HttpHeaderCollection
    {
        private readonly Dictionary<string, HttpHeader> headers;

        public HttpHeaderCollection()
            => this.headers = new();

        public int Count => this.headers.Count;

        public void Add(HttpHeader header)
            => this.headers.Add(header.Name, header);
    }
}
