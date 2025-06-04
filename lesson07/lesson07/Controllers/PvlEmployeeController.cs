using lesson07.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace lesson07.Controllers
{
    public class PvlEmployeeController : Controller
    {
        // Mock Data: 
        private static List<PvlEmployee> PvlListEmployee = new List<PvlEmployee>()
            {
            new PvlEmployee
{
    PvlId = 1,
    PvlName = "Pham Văn Lực ",
    PvlBirthDay = new DateTime(2005, 9, 6),
    PvlEmail = "phamvanlucvx1234@gmail.com",
    PvlPhone = "0846409699",
    PvlSalary = 15000.0m,
    PvlStatus = true
},
new PvlEmployee
{
    PvlId = 2,
    PvlName = "Tran Thi B",
    PvlBirthDay = new DateTime(1985, 3, 15),
    PvlEmail = "b@example.com",
    PvlPhone = "0923456789",
    PvlSalary = 1800.0m,
    PvlStatus = false
},
new PvlEmployee
{
    PvlId = 3,
    PvlName = "Le Van C",
    PvlBirthDay = new DateTime(1992, 8, 10),
    PvlEmail = "c@example.com",
    PvlPhone = "0934567890",
    PvlSalary = 1700.0m,
    PvlStatus = true
},
new PvlEmployee
{
    PvlId = 4,
    PvlName = "Pham Thi D",
    PvlBirthDay = new DateTime(1995, 11, 25),
    PvlEmail = "d@example.com",
    PvlPhone = "0945678901",
    PvlSalary = 1600.0m,
    PvlStatus = false
},
new PvlEmployee
{
    PvlId = 5,
    PvlName = "Hoang Van E",
    PvlBirthDay = new DateTime(1988, 1, 5),
    PvlEmail = "e@example.com",
    PvlPhone = "0956789012",
    PvlSalary = 2000.0m,
    PvlStatus = true
}
};
        // GET: PvlEmployeeController
        public ActionResult PvlIndex()
        {
            return View(PvlListEmployee);
        }

        // GET: PvlEmployeeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PvlEmployeeController/PvlCreate
        public ActionResult PvlCreate()
        {
            var PvlEmployee = new PvlEmployee();
            return View();
        }

        // POST: PvlEmployeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PvlEmployeeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PvlEmployeeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PvlEmployeeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PvlEmployeeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
