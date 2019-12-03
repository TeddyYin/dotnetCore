﻿using System;
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

        public DbSet<User> User { get; set; }
        public DbSet<LanguageList> LanguageList { get; set; }
        public DbSet<LanguageContant> LanguageContant { get; set; }
        public DbSet<LanguageDescription> LanguageDescription { get; set; }
        public DbSet<LanguageRecord> LanguageRecord { get; set; }
        public DbSet<ModuleList> ModuleList { get; set; }
        public DbSet<ModuleLanguage> ModuleLanguage { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
