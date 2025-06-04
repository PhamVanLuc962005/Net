using System.Diagnostics;
using lesson07.Models;
using Microsoft.AspNetCore.Mvc;

namespace lesson07.Controllers
{
    public class PvlHomeController : Controller
    {
        private readonly ILogger<PvlHomeController> _logger;

        public PvlHomeController(ILogger<PvlHomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult PvlIndex()
        {
            return View();
        }

        public IActionResult PvlAbout()
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
