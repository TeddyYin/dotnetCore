using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using dotnetCore.Data;
using dotnetCore.Models;

namespace dotnetCore.Pages.LanguageDescription
{
    public class DeleteModel : PageModel
    {
        private readonly dotnetCore.Data.dotnetCoreContext _context;

        public DeleteModel(dotnetCore.Data.dotnetCoreContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Models.LanguageDescription LanguageDescription { get; set; }

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            LanguageDescription = await _context.LanguageDescription.FirstOrDefaultAsync(m => m.ID == id);

            if (LanguageDescription == null)
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

            LanguageDescription = await _context.LanguageDescription.FindAsync(id);

            if (LanguageDescription != null)
            {
                _context.LanguageDescription.Remove(LanguageDescription);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
