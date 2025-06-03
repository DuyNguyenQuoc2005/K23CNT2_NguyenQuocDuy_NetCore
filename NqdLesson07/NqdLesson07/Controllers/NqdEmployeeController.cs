using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NqdLesson07.Models;

namespace NqdLesson07.Controllers
{
    public class NqdEmployeeController : Controller
    {
        // MockData
        private static List<NqdEmployee> nqdListEmployee = new List<NqdEmployee>()
        {
            new NqdEmployee
            {
                NqdId = 231090030,
                NqdName = "Nguyễn Quốc Duy",
                NqdBirthDay = new DateTime(2005, 2, 18),
                NqdEmail = "yudnguyen2005@gmail.com",
                NqdPhone = "0981652921",
                NqdSalary = 150000000,
                NqdStatus = true
            },
            new NqdEmployee
            {
                NqdId = 2,
                NqdName = "Tran Thi B",
                NqdBirthDay = new DateTime(1992, 5, 20),
                NqdEmail = "b.tran@example.com",
                NqdPhone = "0912345678",
                NqdSalary = 13000000,
                NqdStatus = false
            },
            new NqdEmployee
            {
                NqdId = 3,
                NqdName = "Le Van C",
                NqdBirthDay = new DateTime(1988, 8, 10),
                NqdEmail = "c.le@example.com",
                NqdPhone = "0923456789",
                NqdSalary = 17000000,
                NqdStatus = true
            }
        };
    
        // GET: NqdEmployeeController
        public ActionResult NqdIndex()
        {
            return View(nqdListEmployee);
        }

        // GET: NqdEmployeeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: NqdEmployeeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NqdEmployeeController/Create
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

        // GET: NqdEmployeeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: NqdEmployeeController/Edit/5
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

        // GET: NqdEmployeeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: NqdEmployeeController/Delete/5
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
