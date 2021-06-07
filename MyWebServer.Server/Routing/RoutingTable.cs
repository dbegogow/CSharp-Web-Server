using MyWebServer.Server.Http;
using MyWebServer.Server.Common;
using System.Collections.Generic;

namespace MyWebServer.Server.Routing
{
    public class RoutingTable : IRoutingTable
    {
        private readonly Dictionary<HttpMethod, Dictionary<string, HttpResponse>> routes;

        public RoutingTable()
            => this.routes = new()
            {
                [HttpMethod.Get] = new(),
                [HttpMethod.Post] = new(),
                [HttpMethod.Put] = new(),
                [HttpMethod.Delete] = new()
            };

        public IRoutingTable Map(
            string url,
            HttpMethod method,
            HttpResponse response)
            => method switch
            {
                HttpMethod.Get => this.MapGet(url, response)
            };

        public IRoutingTable MapGet(
            string url,
            HttpResponse response)
        {
            Guard.AgainstNull(url, nameof(url));
            Guard.AgainstNull(response, nameof(response));

            this.routes[HttpMethod.Get][url] = response;

            return this;
        }

        public HttpResponse MatchRequest(HttpRequest request)
        {
            var requestMethod = request.Method;
            var requestUrl = request.Url;

            if (!this.routes.ContainsKey(requestMethod)
                || !this.routes[requestMethod].ContainsKey(requestUrl))
            {

            }
        }
    }
}
