using Microsoft.AspNetCore.Mvc;
using RodoLift.Models;
using System.Diagnostics;

namespace RodoLift.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("/aboutUs")]
        public IActionResult AboutUs()
        {
            return View();
        }

        [HttpGet("/details")]
        public IActionResult Details()
        {
            return View();
        }

    }
}
