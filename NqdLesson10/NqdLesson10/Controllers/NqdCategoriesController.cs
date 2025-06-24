using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NqdLesson10.Models;

namespace NqdLesson10.Controllers
{
    public class NqdCategoriesController : Controller
    {
        private readonly NqdK23cnt2Lesson10Context _context;

        public NqdCategoriesController(NqdK23cnt2Lesson10Context context)
        {
            _context = context;
        }

        // GET: NqdCategories
        public async Task<IActionResult> NqdIndex()
        {
            return View(await _context.NqdCategories.ToListAsync());
        }

        // GET: NqdCategories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nqdCategory = await _context.NqdCategories
                .FirstOrDefaultAsync(m => m.CateId == id);
            if (nqdCategory == null)
            {
                return NotFound();
            }

            return View(nqdCategory);
        }

        // GET: NqdCategories/Create
        public IActionResult NqdCreate()
        {
            return View();
        }

        // POST: NqdCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> NqdCreate([Bind("CateId,CateName,CateStatus")] NqdCategory nqdCategory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nqdCategory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nqdCategory);
        }

        // GET: NqdCategories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nqdCategory = await _context.NqdCategories.FindAsync(id);
            if (nqdCategory == null)
            {
                return NotFound();
            }
            return View(nqdCategory);
        }

        // POST: NqdCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CateId,CateName,CateStatus")] NqdCategory nqdCategory)
        {
            if (id != nqdCategory.CateId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nqdCategory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NqdCategoryExists(nqdCategory.CateId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(nqdCategory);
        }

        // GET: NqdCategories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nqdCategory = await _context.NqdCategories
                .FirstOrDefaultAsync(m => m.CateId == id);
            if (nqdCategory == null)
            {
                return NotFound();
            }

            return View(nqdCategory);
        }

        // POST: NqdCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var nqdCategory = await _context.NqdCategories.FindAsync(id);
            if (nqdCategory != null)
            {
                _context.NqdCategories.Remove(nqdCategory);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NqdCategoryExists(int id)
        {
            return _context.NqdCategories.Any(e => e.CateId == id);
        }
    }
}
