using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovies.Controllers
{
    // each method in here is an HTTP endpoint
    // action methods here return IActionResult, not a type like string
    public class HelloWorldController : Controller
    {
        // GET /HelloWorld/Index
        public IActionResult Index()
        {
            // if you don't specify which view, it returns the Index.cshtml view in Views/HelloWorld
            return View();
        }
        

        // GET HelloWorld/Welcome
        public string Welcome(string name, int id = 1)
        {
            // html encode protects us from malicious input
            return HtmlEncoder.Default.Encode($"Welcome to the Films Database {name}! Your ID is {id}");
        }
    }
}