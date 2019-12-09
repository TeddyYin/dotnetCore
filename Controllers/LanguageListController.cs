using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using dotnetCore.Data;
using dotnetCore.Models;

namespace dotnetCore.Controllers
{
    public class LanguageListController : Controller
    {
        private readonly dotnetCoreContext _context;

        public LanguageListController(dotnetCoreContext context)
        {
            _context = context;
        }

        // GET: LanguageList
        public async Task<IActionResult> Index()
        {
            return View(await _context.LanguageList.ToListAsync());
        }

        // GET: LanguageList/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var languageList = await _context.LanguageList
                .FirstOrDefaultAsync(m => m.ID == id);
            if (languageList == null)
            {
                return NotFound();
            }

            return View(languageList);
        }

        // GET: LanguageList/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LanguageList/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,Position,Connection,Status")] LanguageList languageList)
        {
            if (ModelState.IsValid)
            {
                languageList.ID = Guid.NewGuid();
                _context.Add(languageList);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(languageList);
        }

        // GET: LanguageList/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var languageList = await _context.LanguageList.FindAsync(id);
            if (languageList == null)
            {
                return NotFound();
            }
            return View(languageList);
        }

        // POST: LanguageList/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("ID,Name,Position,Connection,Status")] LanguageList languageList)
        {
            if (id != languageList.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(languageList);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LanguageListExists(languageList.ID))
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
            return View(languageList);
        }

        // GET: LanguageList/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var languageList = await _context.LanguageList
                .FirstOrDefaultAsync(m => m.ID == id);
            if (languageList == null)
            {
                return NotFound();
            }

            return View(languageList);
        }

        // POST: LanguageList/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var languageList = await _context.LanguageList.FindAsync(id);
            _context.LanguageList.Remove(languageList);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LanguageListExists(Guid id)
        {
            return _context.LanguageList.Any(e => e.ID == id);
        }
    }
}
