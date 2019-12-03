using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using dotnetCore.Data;
using dotnetCore.Models;

namespace dotnetCore.Pages.LanguageRecord
{
    public class DetailsModel : PageModel
    {
        private readonly dotnetCore.Data.dotnetCoreContext _context;

        public DetailsModel(dotnetCore.Data.dotnetCoreContext context)
        {
            _context = context;
        }

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
    }
}
