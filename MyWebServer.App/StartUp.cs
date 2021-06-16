using System.Threading.Tasks;
using MyWebServer.Controllers;
using MyWebServer.App.Controllers;

namespace MyWebServer.App
{
    class StartUp
    {
        public static async Task Main()
            => await new HttpServer(routes => routes
                    .MapStaticFiles()
                    .MapControllers()
                    .MapGet<HomeController>("/ToCats", c => c.LocalRedirect()))
                .Start();
    }
}
