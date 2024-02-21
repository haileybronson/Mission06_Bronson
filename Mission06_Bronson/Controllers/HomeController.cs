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
            return View("Movies", new Movie());
        }


        [HttpPost]
        public IActionResult Movies(Movie response)
        {
            //The “Edited”, “Lent To”, and “Notes” are not required to create a new
            //record. All other fields must be entered.
            //if its not null, return, if it is null, set to empty string
            //response.LentTo = response.LentTo ?? "";
            //response.Notes = response.Notes ?? "";
            if (ModelState.IsValid)
            {
                _context.Movies.Add(response); //adds record to the database
                _context.SaveChanges();

                return View("Confirmation", response);
            }
            else
            {
                return View(response);
            }
            
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

        //updating/editing infos
        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var recordToEdit = _context.Movies
                .Single(x => x.MovieId == Id);
            
            return View("Movies", recordToEdit);
        }

        //updating infos
        [HttpPost]
        public IActionResult Edit(Movie updatedInfo)
        {
            _context.Update(updatedInfo);
            _context.SaveChanges();

            return RedirectToAction("MovieList");
        }

        //deleting infos 
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var recordToDelete = _context.Movies
                .Single(x => x.MovieId == id);

            return View(recordToDelete);
        }

        [HttpPost]
        public IActionResult Delete(Movie deletedInfo)
        {
            _context.Movies.Remove(deletedInfo);
            _context.SaveChanges();

            return RedirectToAction("MovieList");
        }
    }
}
