using System.Linq;
using MyWebServer.App.Data;
using MyWebServer.Http;
using MyWebServer.Controllers;

namespace MyWebServer.App.Controllers
{
    public class CatsController : Controller
    {
        private readonly IData data;

        public CatsController(IData data)
            => this.data = data;

        public HttpResponse All()
        {
            var cats = this.data
                .Cats
                .ToList();

            return View(cats);
        }

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
