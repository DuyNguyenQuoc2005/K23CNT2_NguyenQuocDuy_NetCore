using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NqdLesson11.Models;

namespace NqdLesson11.Controllers
{
    public class NqdCategoriesController : Controller
    {
        private readonly NguyenQuocDuy2310900030Context _context;

        public NqdCategoriesController(NguyenQuocDuy2310900030Context context)
        {
            _context = context;
        }

        // GET: NqdCategories
        public async Task<IActionResult> NqdIndex()
        {
            return View(await _context.Categories.ToListAsync());
        }

        // GET: NqdCategories/Details/5
        public async Task<IActionResult> NqdDetails(int? nqdId)
        {
            if (nqdId == null)
            {
                return NotFound();
            }

            var category = await _context.Categories
                .FirstOrDefaultAsync(m => m.NqdEmpId == nqdId);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
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
        public async Task<IActionResult> NqdCreate([Bind("NqdEmpId,NqdEmpName,NqdEmpLevel,NqdEmpStartDate,NqdEmpStatus")] Category category)
        {
            if (ModelState.IsValid)
            {
                _context.Add(category);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(NqdIndex));
            }
            return View(category);
        }

        // GET: NqdCategories/Edit/5
        public async Task<IActionResult> NqdEdit(int? nqdId)
        {
            if (nqdId == null)
            {
                return NotFound();
            }

            var category = await _context.Categories.FindAsync(nqdId);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        // POST: NqdCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> NqdEdit(int nqdId, [Bind("NqdEmpId,NqdEmpName,NqdEmpLevel,NqdEmpStartDate,NqdEmpStatus")] Category category)
        {
            if (nqdId != category.NqdEmpId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(category);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CategoryExists(category.NqdEmpId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(NqdIndex));
            }
            return View(category);
        }

        // GET: NqdCategories/Delete/5
        public async Task<IActionResult> NqdDelete(int? nqdId)
        {
            if (nqdId == null)
            {
                return NotFound();
            }

            var category = await _context.Categories
                .FirstOrDefaultAsync(m => m.NqdEmpId == nqdId);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        // POST: NqdCategories/Delete/5
        [HttpPost, ActionName("NqdDelete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int nqdId)
        {
            var category = await _context.Categories.FindAsync(nqdId);
            if (category != null)
            {
                _context.Categories.Remove(category);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(NqdIndex));
        }

        private bool CategoryExists(int nqdId)
        {
            return _context.Categories.Any(e => e.NqdEmpId == nqdId);
        }
    }
}
