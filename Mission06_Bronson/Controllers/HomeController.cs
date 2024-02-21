using Microsoft.AspNetCore.Mvc;
using Mission06_Bronson.Models;
using System.Diagnostics;

namespace Mission06_Bronson.Controllers
{
    public class HomeController : Controller
    {
        private MovieFormContext _context;

        public HomeController(MovieFormContext temp)
        {
            _context = temp;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Movies()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Movies(Movie response)
        {
            //The “Edited”, “Lent To”, and “Notes” are not required to create a new
            //record. All other fields must be entered.
            //if its not null, return, if it is null, set to empty string
            //response.LentTo = response.LentTo ?? "";
            //response.Notes = response.Notes ?? "";

            _context.Movies.Add(response); //adds record to the database
            _context.SaveChanges();

            return View("Confirmation");
        }

        public IActionResult knowJoel()
        {
            return View();
        }

        public IActionResult MovieList()
        {
            //Linq
            var movies = _context.Movies
                .OrderBy(x => x.Title).ToList();

            return View(movies);
        }

        public IActionResult Edit(int recordId)
        {
            var recordToEdit = _context.Movies
                .Where(x => x.MovieId == recordId);
            
            return View("Movies");
        }


    }
}
