using Microsoft.EntityFrameworkCore;
using SeboNasCanelas.Win.AppObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeboNasCanelas.Win
{
    public class SeboNasCanelasContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        public SeboNasCanelasContext() : base()
        {
            
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Data Source=(LOCAL); Initial Catalog=SeboNasCanelas; User ID=Sa; Password=SqlServer2019!");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            
        }
    }
}