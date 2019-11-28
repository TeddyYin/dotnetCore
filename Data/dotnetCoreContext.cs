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

        public DbSet<LanguageContant> LanguageContant { get; set; }
        public DbSet<LanguageDescription> LanguageDescription { get; set; }
        public DbSet<LanguageList> LanguageList { get; set; }
        public DbSet<LanguageRecord> LanguageRecord { get; set; }
        public DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LanguageList>()
                .HasMany(x => x.User)
                .WithOne(c => c.Language);
        }
    }
}
