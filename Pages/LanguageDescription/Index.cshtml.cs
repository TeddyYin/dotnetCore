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
    public class IndexModel : PageModel
    {
        private readonly dotnetCore.Data.dotnetCoreContext _context;

        public IndexModel(dotnetCore.Data.dotnetCoreContext context)
        {
            _context = context;
        }

        public IList<Models.LanguageDescription> LanguageDescription { get;set; }

        public async Task OnGetAsync()
        {
            LanguageDescription = await _context.LanguageDescription.ToListAsync();
        }
    }
}
