using System.Collections.Generic;
using MyWebServer.App.Data.Models;

namespace MyWebServer.App.Data
{
    public class MyDbContext : IData
    {
        public MyDbContext()
            => this.Cats = new List<Cat>
            {
                new() {Id = 1, Name = "Sharo", Age = 5},
                new() {Id = 2, Name = "Lady", Age = 13},
            };

        public IEnumerable<Cat> Cats { get; }
    }
}
