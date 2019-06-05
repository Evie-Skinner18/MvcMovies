using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MvcMovies.Controllers
{
    // each method in here is an HTTP endpoint
    public class HelloWorldController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

            // GET /HelloWorld
        public string Index()
        {
            return "Hello world! this is my default action.";
        }

        // GET HelloWorld/Welcome
        public string Welcome()
        {
            return "Welcome to the Films Database!";
        }
    }
}