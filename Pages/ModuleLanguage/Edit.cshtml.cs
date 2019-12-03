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

namespace dotnetCore.Pages.ModuleLanguage
{
    public class EditModel : PageModel
    {
        private readonly dotnetCore.Data.dotnetCoreContext _context;

        public EditModel(dotnetCore.Data.dotnetCoreContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Models.ModuleLanguage ModuleLanguage { get; set; }

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ModuleLanguage = await _context.ModuleLanguage.FirstOrDefaultAsync(m => m.ID == id);

            if (ModuleLanguage == null)
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

            _context.Attach(ModuleLanguage).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ModuleLanguageExists(ModuleLanguage.ID))
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

        private bool ModuleLanguageExists(Guid id)
        {
            return _context.ModuleLanguage.Any(e => e.ID == id);
        }
    }
}
