﻿using MyWebServer.Http;
using MyWebServer.Controllers;

namespace MyWebServer.App.Controllers
{
    public class CatsController : Controller
    {
        public CatsController(HttpRequest request)
            : base(request)
        {
        }

        [HttpGet]
        public HttpResponse Create()
            => View();

        [HttpPost]
        public HttpResponse Save()
        {
            var name = this.Request.Form["Name"];
            var age = this.Request.Form["Age"];

            return Text($"{name} - {age}");
        }
    }
}
