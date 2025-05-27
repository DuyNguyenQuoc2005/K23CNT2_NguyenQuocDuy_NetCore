using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NqdLesson05.Models.DataModels
{
    public class NqdMember : Controller
    {
        // GET: NqdMember
        public ActionResult Index()
        {
            return View();
        }

        // GET: NqdMember/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: NqdMember/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NqdMember/Create
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

        // GET: NqdMember/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: NqdMember/Edit/5
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

        // GET: NqdMember/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: NqdMember/Delete/5
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
