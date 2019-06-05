using Microsoft.AspNetCore.Mvc;
using MvcMovies.Models;
using System.Diagnostics;


namespace MvcMovies.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
