using MyWebServer.Server;
using System.Threading.Tasks;
using MyWebServer.Server.Responses;

namespace MyWebServer
{
    class StartUp
    {
        public static async Task Main()
            => await new HttpServer(routes => routes
                    .MapGet("/", new TextResponse("Hello from Dzhulio!"))
                    .MapGet("/Cats", new HtmlResponse("<h1>Hello from the cats!</h1>"))
                    .MapGet("/Dogs", new HtmlResponse("<h1>Hello from the dogs!</h1>")))
                .Start();

    }
}
