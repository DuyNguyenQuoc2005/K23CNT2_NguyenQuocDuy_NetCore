using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NqdLesson05.Models;

namespace NqdLesson05.Controllers
{
    public class NqdHomeController : Controller
    {
        private readonly ILogger<NqdHomeController> _logger;

        public NqdHomeController(ILogger<NqdHomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult NqdIndex()
        {
            return View();
        }

        public IActionResult NqdAbout()
        {
            return View();
        }

        public IActionResult Privacy()
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
