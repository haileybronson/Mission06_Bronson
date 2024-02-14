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
        public IActionResult form()
        {
            return View("form");
        }


        [HttpPost]
        public IActionResult form(Form response)
        {
            //The “Edited”, “Lent To”, and “Notes” are not required to create a new
            //record. All other fields must be entered.
            //if its not null, return, if it is null, set to empty string
            response.MovieLent = response.MovieLent ?? "";
            response.MovieNotes = response.MovieNotes ?? "";

            _context.Forms.Add(response); //adds record to the database
            _context.SaveChanges();

            return View("Confirmation");
        }

        public IActionResult knowJoel()
        {
            return View();
        }

        


    }
}
