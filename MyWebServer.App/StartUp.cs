using System.Threading.Tasks;
using MyWebServer.Controllers;
using MyWebServer.App.Controllers;

namespace MyWebServer.App
{
    class StartUp
    {
        public static async Task Main()
            => await new HttpServer(routes => routes
                    .MapGet<HomeController>("/", c => c.Index())
                    .MapGet<AnimalsController>("/Cats", c => c.Cats())
                    .MapGet<AnimalsController>("/Dogs", c => c.Dogs()))
                .Start();
    }
}
