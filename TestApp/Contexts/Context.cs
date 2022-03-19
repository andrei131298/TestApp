using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TestApp.Contexts
{
    public class Context: DbContext
    {
        //public DbSet<City> Cities { get; set; }
       
        public static bool isMigration = true;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (isMigration)
                optionsBuilder.UseSqlServer(@"Server=.\;Database=VacayCheckDB;Trusted_Connection=true;");           
        }
        public Context() { }
        public Context(DbContextOptions<Context> options) : base(options) { }

    }

}
