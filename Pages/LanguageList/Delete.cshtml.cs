using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using dotnetCore.Data;
using dotnetCore.Models;

namespace dotnetCore.Pages.LanguageList
{
    public class DeleteModel : PageModel
    {
        private readonly dotnetCore.Data.dotnetCoreContext _context;

        public DeleteModel(dotnetCore.Data.dotnetCoreContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Models.LanguageList LanguageList { get; set; }

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            LanguageList = await _context.LanguageList.FirstOrDefaultAsync(m => m.ID == id);

            if (LanguageList == null)
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

            LanguageList = await _context.LanguageList.FindAsync(id);

            if (LanguageList != null)
            {
                _context.LanguageList.Remove(LanguageList);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
