using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using dotnetCore.Data;
using dotnetCore.Models;

namespace dotnetCore.Pages.LanguageContant
{
    public class DetailsModel : PageModel
    {
        private readonly dotnetCore.Data.dotnetCoreContext _context;

        public DetailsModel(dotnetCore.Data.dotnetCoreContext context)
        {
            _context = context;
        }

        public Models.LanguageContant LanguageContant { get; set; }

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            LanguageContant = await _context.LanguageContant.FirstOrDefaultAsync(m => m.ID == id);

            if (LanguageContant == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
