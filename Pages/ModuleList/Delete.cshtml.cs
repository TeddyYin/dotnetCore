using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using dotnetCore.Data;
using dotnetCore.Models;

namespace dotnetCore.Pages.ModuleList
{
    public class DeleteModel : PageModel
    {
        private readonly dotnetCore.Data.dotnetCoreContext _context;

        public DeleteModel(dotnetCore.Data.dotnetCoreContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Models.ModuleList ModuleList { get; set; }

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ModuleList = await _context.ModuleList.FirstOrDefaultAsync(m => m.ID == id);

            if (ModuleList == null)
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

            ModuleList = await _context.ModuleList.FindAsync(id);

            if (ModuleList != null)
            {
                _context.ModuleList.Remove(ModuleList);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
