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
    }
}
