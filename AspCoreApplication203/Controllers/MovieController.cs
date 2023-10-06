using AspCoreApplication203.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.CodeAnalysis;

namespace AspCoreApplication203.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index(int id)
        {
            List<Movie> movies = new List<Movie>()
            {
                new Movie(1, "test1"),
                new Movie(2, "test2")
            };
            return View(movies);
        }
        [Route("movie/released/{year}/{month}")]
        public IActionResult ByRelease(int year, int month)
        {
            return Content("movie in "+year+"/"+month);
        }
    }
}
