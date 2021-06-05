using MyWebServer.Server.Http;

namespace MyWebServer.Server.Routing
{
    public interface IRoutingTable
    {
        IRoutingTable Map(string url, HttpMethod method, HttpResponse response);

        IRoutingTable MapGet(string url, HttpResponse response);
    }
}
