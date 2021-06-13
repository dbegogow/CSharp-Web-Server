using MyWebServer.Http;
using MyWebServer.Results;
using MyWebServer.Controllers;

namespace MyWebServer.App.Controllers
{
    public class AccountController : Controller
    {
        public AccountController(HttpRequest request)
            : base(request)
        {
        }

        public ActionResult ActionWithCookies()
        {
            this.Response.AddCookie("My-Cookie", "My-Value");
            this.Response.AddCookie("My-Second-Cookie", "My-Second-Value");

            return Text("Hello!");
        }
    }
}
