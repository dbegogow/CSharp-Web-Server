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
            const string cookieName = "My-Cookie";

            if (this.Request.Cookies.ContainsKey(cookieName))
            {
                var cookie = this.Request.Cookies[cookieName];

                return Text($"Cookies already exist - {cookie}");
            }

            this.Response.AddCookie("My-Cookie", "My-Value");
            this.Response.AddCookie("My-Second-Cookie", "My-Second-Value");

            return Text("Cookies set!");
        }
    }
}
