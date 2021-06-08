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
                    .MapGet("/Cats", request =>
                    {
                        const string nameKey = "Name";

                        var query = request.Query;

                        var catName = query.ContainsKey(nameKey)
                            ? query[nameKey]
                            : "the cats";

                        var result = $"<h1>Hello from {catName}!</h1>";

                        return new HtmlResponse(result);
                    })
                    .MapGet("/Dogs", new HtmlResponse("<h1>Hello from the dogs!</h1>")))
                .Start();

    }
}
