using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovies.Controllers
{
    // each method in here is an HTTP endpoint
    public class HelloWorldController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

            // GET /HelloWorld/Index
        public string Index()
        {
            return "Hello world! this is my default action.";
        }

        // GET HelloWorld/Welcome
        public string Welcome(string name, int id = 1)
        {
            // html encode protects us from malicious input
            return HtmlEncoder.Default.Encode($"Welcome to the Films Database {name}! Your ID is {id}");
        }
    }
}