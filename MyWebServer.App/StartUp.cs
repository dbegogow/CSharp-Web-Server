using MyWebServer.App.Data;
using System.Threading.Tasks;
using MyWebServer.Controllers;
using MyWebServer.App.Controllers;

namespace MyWebServer.App
{
    class StartUp
    {
        public static async Task Main()
            => await HttpServer
                .WithRoutes(routes => routes
                    .MapStaticFiles()
                    .MapControllers()
                    .MapGet<HomeController>("/ToCats", c => c.LocalRedirect()))
                .WithServices(services => services
                    .Add<IData, MyDbContext>())
                .Start();
    }
}
