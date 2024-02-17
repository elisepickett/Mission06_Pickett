using Microsoft.AspNetCore.Mvc;
using Mission06_Pickett.Models;
using System.Diagnostics;

namespace Mission06_Pickett.Controllers
{
    public class HomeController : Controller
    {
        private AddMovieContext _context;
        public HomeController(AddMovieContext somename)
        {
            _context = somename;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetToKnowJoel()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddMovie()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddMovie(Application response)
        {
            _context.Movies.Add(response);
            _context.SaveChanges();
            return View();
        }

    }
}
