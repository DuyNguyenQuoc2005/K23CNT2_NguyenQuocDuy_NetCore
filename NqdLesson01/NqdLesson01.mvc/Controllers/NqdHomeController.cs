using Microsoft.AspNetCore.Mvc;
using NqdLesson01.mvc.Models;
using System.Diagnostics;

namespace NqdLesson01.mvc.Controllers
{
    public class NqdHomeController : Controller
    {
        private readonly ILogger<NqdHomeController> _logger;

        public NqdHomeController(ILogger<NqdHomeController> logger)
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
