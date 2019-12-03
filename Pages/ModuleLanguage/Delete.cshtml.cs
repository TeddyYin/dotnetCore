using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using dotnetCore.Data;
using dotnetCore.Models;

namespace dotnetCore.Pages.ModuleLanguage
{
    public class DeleteModel : PageModel
    {
        private readonly dotnetCore.Data.dotnetCoreContext _context;

        public DeleteModel(dotnetCore.Data.dotnetCoreContext context)
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

        public async Task<IActionResult> OnPostAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ModuleLanguage = await _context.ModuleLanguage.FindAsync(id);

            if (ModuleLanguage != null)
            {
                _context.ModuleLanguage.Remove(ModuleLanguage);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
