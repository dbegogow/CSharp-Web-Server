using MyWebServer.Server;
using System.Threading.Tasks;

namespace MyWebServer
{
    class StartUp
    {
        public static async Task Main()
        {
            var server = new HttpServer("127.0.0.1", 9090);

            await server.Start();
        }
    }
}
