using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using StudentBalancePrototype.Models;

namespace StudentBalancePrototype.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult NewAssignment()
        {
            return View();
        }

        public IActionResult LogDailyHabits()
        {
            return View();
        }

        public IActionResult Academic()
        {
            return View();
        }

        public IActionResult ProgressStreaks()
        {
            return View();
        }

        public IActionResult StudyTimer()
        {
            return View();
        }

        public IActionResult Wellness()
        {
            return View();
        }

        public IActionResult Motivation()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
