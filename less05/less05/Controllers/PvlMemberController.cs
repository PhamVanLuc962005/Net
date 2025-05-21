using Microsoft.AspNetCore.Mvc;
using less05.Models.DataModels;

namespace lesson05.Controllers
{
    public class PvlMemberController : Controller
    {
        private static List<PvlMemBer> PvlListMembers = new List<PvlMemBer>()
        {
            new PvlMemBer
            {
                PvlMemberId = "2310900059",
                PvlUserName = "PhamLuc",
                PvlPassword = "Lucvx123",
                PvlFullName = "Pham Van Luc",
                PvlEmail = "phamlucvx1234@gmail.com"
            },
            new PvlMemBer
            {
                PvlMemberId = "002",
                PvlUserName = "user2",
                PvlPassword = "pass2",
                PvlFullName = "Tran Thi B",
                PvlEmail = "user2@example.com"
            },
            new PvlMemBer
            {
                PvlMemberId = "003",
                PvlUserName = "user3",
                PvlPassword = "pass3",
                PvlFullName = "Le Van C",
                PvlEmail = "user3@example.com"
            },
            new PvlMemBer
            {
                PvlMemberId = "004",
                PvlUserName = "user4",
                PvlPassword = "pass4",
                PvlFullName = "Pham Thi D",
                PvlEmail = "user4@example.com"
            },
            new PvlMemBer
            {
                PvlMemberId = "005",
                PvlUserName = "user5",
                PvlPassword = "pass5",
                PvlFullName = "Hoang Van E",
                PvlEmail = "user5@example.com"
            }
        };
        public IActionResult Index()
        {
            return View(PvlListMembers);
        }
    }
}