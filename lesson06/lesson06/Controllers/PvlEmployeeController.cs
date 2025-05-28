using lesson06.Models;
using Microsoft.AspNetCore.Mvc;
using lesson06.Models;

namespace lesson06.Controllers
{
    public class PvlEmployeeController : Controller
    {
        static List<PvlEmployee> PvlListEmployee = new List<PvlEmployee>
        {
            new PvlEmployee { PvlId = 1, PvlName = "Phạm Văn Lực ", PvlBirthDay = new DateTime(2005,9,6), PvlEmail = "phamlucvx1234@gmail.com", PvlPhone = "0357979247", PvlSalary = 100000000, PvlStatus = true },
            new PvlEmployee { PvlId = 2, PvlName = "Vũ Thị Hồng Hạnh", PvlBirthDay = new DateTime(2007,1,1), PvlEmail = "hanh99@gmail.com", PvlPhone = "0902222222", PvlSalary = 6500, PvlStatus = true },
            new PvlEmployee { PvlId = 3, PvlName = "Lê Văn C", PvlBirthDay = new DateTime(1998,3,3), PvlEmail = "c@gmail.com", PvlPhone = "0903333333", PvlSalary = 7000, PvlStatus = false },
            new PvlEmployee { PvlId = 4, PvlName = "Phạm Thị D", PvlBirthDay = new DateTime(1997,4,4), PvlEmail = "d@gmail.com", PvlPhone = "0904444444", PvlSalary = 5500, PvlStatus = true },
            new PvlEmployee { PvlId = 5, PvlName = "Nguyễn Sinh Viên", PvlBirthDay = new DateTime(2003,5,5), PvlEmail = "sv@gmail.com", PvlPhone = "0905555555", PvlSalary = 8000, PvlStatus = true }
        };

        public IActionResult PvlIndex() => View(PvlListEmployee);

        public IActionResult PvlCreate() => View();

        [HttpPost]
        public IActionResult PvlCreateSubmit(PvlEmployee emp)
        {
            emp.PvlId = PvlListEmployee.Max(e => e.PvlId) + 1;
            PvlListEmployee.Add(emp);
            return RedirectToAction("PvlIndex");
        }

        public IActionResult PvlEdit(int id)
        {
            var emp = PvlListEmployee.FirstOrDefault(e => e.PvlId == id);
            return View(emp);
        }

        [HttpPost]
        public IActionResult PvlEditPUT(PvlEmployee emp)
        {
            var item = PvlListEmployee.FirstOrDefault(e => e.PvlId == emp.PvlId);
            if (item != null)
            {
                item.PvlName = emp.PvlName;
                item.PvlBirthDay = emp.PvlBirthDay;
                item.PvlEmail = emp.PvlEmail;
                item.PvlPhone = emp.PvlPhone;
                item.PvlSalary = emp.PvlSalary;
                item.PvlStatus = emp.PvlStatus;
            }
            return RedirectToAction("PvlIndex");
        }

        public IActionResult PvlDelete(int id)
        {
            var emp = PvlListEmployee.FirstOrDefault(e => e.PvlId == id);
            if (emp != null) PvlListEmployee.Remove(emp);
            return RedirectToAction("PvlIndex");
        }
    }
}