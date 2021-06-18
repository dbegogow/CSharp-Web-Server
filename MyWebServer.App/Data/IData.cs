using System.Collections.Generic;
using MyWebServer.App.Data.Models;

namespace MyWebServer.App.Data
{
    public interface IData
    {
        IEnumerable<Cat> Cats { get; }
    }
}
