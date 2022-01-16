using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstEfCoreApp.Models
{
    public class AppDbContext : DbContext
    {
        private const string ConnectionString = "Server=s4e7hjv3.instances.spawn.cc,31423;Database=MyFirstEfCoreApp;User Id=sa;Password=;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)       //Needed in console apps
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }

        public DbSet<Book> Books { get; set; }      //No need for Authors as it's already covered by relationship from Books.
    }
}
