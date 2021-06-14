using System;
using MyWebServer.Http;
using MyWebServer.Controllers;

namespace MyWebServer.App.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(HttpRequest request)
            : base(request)
        {
        }

        public HttpResponse Index()
            => Text("Hello from Dzhulio!");

        public HttpResponse LocalRedirect()
            => Redirect("/Cats");

        public HttpResponse ToSoftUni()
            => Redirect("https://softuni.bg");

        public HttpResponse Error() 
            => throw new InvalidOperationException("Invalid action!");
    }
}
