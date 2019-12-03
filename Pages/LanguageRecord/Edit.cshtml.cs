using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using dotnetCore.Data;
using dotnetCore.Models;

namespace dotnetCore.Pages.LanguageRecord
{
    public class EditModel : PageModel
    {
        private readonly dotnetCore.Data.dotnetCoreContext _context;

        public EditModel(dotnetCore.Data.dotnetCoreContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Models.LanguageRecord LanguageRecord { get; set; }

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            LanguageRecord = await _context.LanguageRecord.FirstOrDefaultAsync(m => m.ID == id);

            if (LanguageRecord == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(LanguageRecord).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LanguageRecordExists(LanguageRecord.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool LanguageRecordExists(Guid id)
        {
            return _context.LanguageRecord.Any(e => e.ID == id);
        }
    }
}
