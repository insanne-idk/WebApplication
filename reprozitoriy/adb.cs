using System.Collections.Generic;
using System;
using WebApplication6черников.Новая_папка;
using Microsoft.EntityFrameworkCore;
using WebApplication6черников.Model.authApp;

namespace WebApplication6черников.reprozitoriy
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Seriali>? Serialis { get; set; }
        public DbSet<AuthUser>? AuthUsers { get; set; }
        public object Seriali { get; internal set; }
    }
    


    }

