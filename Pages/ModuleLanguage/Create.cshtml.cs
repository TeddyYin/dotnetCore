using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using dotnetCore.Data;
using dotnetCore.Models;

namespace dotnetCore.Pages.ModuleLanguage
{
    public class CreateModel : PageModel
    {
        private readonly dotnetCore.Data.dotnetCoreContext _context;

        public CreateModel(dotnetCore.Data.dotnetCoreContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Models.ModuleLanguage ModuleLanguage { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.ModuleLanguage.Add(ModuleLanguage);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
