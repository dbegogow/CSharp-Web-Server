using MyWebServer.App.Models.Animals;
using MyWebServer.Http;
using MyWebServer.Controllers;

namespace MyWebServer.App.Controllers
{
    public class AnimalsController : Controller
    {
        public HttpResponse Cats()
        {
            const string nameKey = "Name";
            const string ageKey = "Age";

            var query = Request.Query;

            var catName = query.ContainsKey(nameKey)
                ? query[nameKey]
                : "the cats";

            var catAge = query.ContainsKey(ageKey)
                ? int.Parse(query[ageKey])
                : 0;

            var viewModel = new CatViewModel
            {
                Name = catName,
                Age = catAge
            };

            return View(viewModel);
        }

        public HttpResponse Dogs()
            => View(new DogViewModel
            {
                Name = "Rex",
                Age = 3,
                Breed = "Street Perfect"
            });

        public HttpResponse Bunnies()
            => View("Rabbits");

        public HttpResponse Turtles()
            => View("Animals/Wild/Turtles");
    }
}
