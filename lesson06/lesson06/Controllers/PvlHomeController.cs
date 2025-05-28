using System.Diagnostics;
using lesson06.Models;
using Microsoft.AspNetCore.Mvc;
using lesson06.Models;

namespace lesson06.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult PvlAbout()
        {
            ViewBag.StudentName = "Phạm Văn Lực";
            ViewBag.StudentID = "2310900059";
            ViewBag.Class = "CNTT3";
            ViewBag.Quote = "“Học để biết, học để làm, học để kiếm tiền.”";
            return View();
        }
    }
}
