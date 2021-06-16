using System;
using MyWebServer.Http;

namespace MyWebServer.Controllers
{
    [AttributeUsage(AttributeTargets.Method)]
    public abstract class HttpMethodAttribute : Attribute
    {
        protected HttpMethodAttribute(HttpMethod httpMethod)
            => this.HttpMethod = httpMethod;

        public HttpMethod HttpMethod { get; }
    }
}
