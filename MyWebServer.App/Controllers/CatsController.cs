using MyWebServer.Http;
using MyWebServer.Controllers;

namespace MyWebServer.App.Controllers
{
    public class CatsController : Controller
    {
        [HttpGet]
        public HttpResponse Create()
            => View();

        [HttpPost]
        public HttpResponse Save(string name, int age)
        {
            return Text($"{name} - {age}");
        }
    }
}
