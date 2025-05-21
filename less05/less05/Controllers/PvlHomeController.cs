using System.Diagnostics;
using less05.Models;
using less05.Models.DataModels;
using Microsoft.AspNetCore.Mvc;

namespace less05.Controllers
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

        public IActionResult PvlAbot()
        {
            PvlMemBer pvlMembers = new PvlMemBer();
            pvlMembers.PvlMemberId = Guid.NewGuid().ToString();
            pvlMembers.PvlUserName = "PvlUserName";
            pvlMembers.PvlPassword = "PvlPassword";
            pvlMembers.PvlFullName = "pvlFullName";
            pvlMembers.PvlEmail = "PvlEmail";
            return View(pvlMembers);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
