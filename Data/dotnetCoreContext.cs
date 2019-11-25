using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using dotnetCore.Models;

namespace dotnetCore.Data
{
    public class dotnetCoreContext : DbContext
    {
        public dotnetCoreContext (DbContextOptions<dotnetCoreContext> options)
            : base(options)
        {
        }

        public DbSet<dotnetCore.Models.User> User { get; set; }
        public DbSet<dotnetCore.Models.DefaultLanguage> DefaultLanguage { get; set; }
        public DbSet<dotnetCore.Models.LanguageContant> LanguageContant { get; set; }
        public DbSet<dotnetCore.Models.LanguageList> LanguageList { get; set; }
    }
}
