using Microsoft.AspNetCore.Mvc;
using NqdLesson06.Models;

namespace NqdLesson06.Controllers
{
    public class NqdEmployeeController : Controller
    {
        private static List<NqdEmployee> nqdListEmployee = new List<NqdEmployee>()
        {
             new NqdEmployee
            {
                NqdId = 1,
                NqdName = "Nguyễn Quốc Duy",
                NqdBirthDay = new DateTime(2005, 2, 18),
                NqdEmail = "yudnguyen2005@gmail.com",
                NqdPhone = "0981652921",
                NqdSalary = 15000000,
                NqdStatus = true
            },
            new NqdEmployee
            {
                NqdId = 2,
                NqdName = "Nguyễn Huy Khánh",
                NqdBirthDay = new DateTime(2005, 1, 13),
                NqdEmail = "huykhanh6969@gmail.com",
                NqdPhone = "0912344556",
                NqdSalary = 13000000,
                NqdStatus = false
            },
            new NqdEmployee
            {
                NqdId = 3,
                NqdName = "Nguyễn Duy Thông",
                NqdBirthDay = new DateTime(2005, 9, 4),
                NqdEmail = "thongkhanh9696@gmail.com",
                NqdPhone = "0923344556",
                NqdSalary = 17000000,
                NqdStatus = true
            }
        };
        public IActionResult NqdIndex()
        {
            return View(nqdListEmployee);
        }
        public IActionResult NqdCreate()
        {
            return View();
        }
        [HttpPost]
        public IActionResult NqdCreate(NqdEmployee model)
        {
            // Tự động tăng ID
            model.NqdId = nqdListEmployee.Count > 0
                ? nqdListEmployee.Max(e => e.NqdId) + 1
                : 1;

            nqdListEmployee.Add(model);
            return RedirectToAction("NqdIndex");
        }

    }
}
   