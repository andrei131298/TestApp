using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TestApp.Models;

namespace TestApp.Contexts
{
    public class Context: DbContext
    {
        public DbSet<Product> Product { get; set; }
        public DbSet<Category> Category { get; set; }

        public static bool isMigration = true;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (isMigration)
                optionsBuilder.UseSqlServer(@"Server=.\;Database=ShopDB;Trusted_Connection=true;");           
        }
        public Context() { }
        public Context(DbContextOptions<Context> options) : base(options) { }

    }

}
