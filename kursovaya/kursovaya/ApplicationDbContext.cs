using kursovaya.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursovaya
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }
        public ApplicationDbContext()
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=MyDatabase;Trusted_Connection=True;");
            }
        }
        
        
        // Наборы данных
        public DbSet<Table> Tables { get; set; }
        public DbSet<Vivod> Vivods { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Настройка связи один-к-одному
            modelBuilder.Entity<Vivod>()
                .HasOne(v => v.Table) // Vivod связан с одной Table
                .WithOne(t => t.Vivod) // Table связан с одним Vivod
                .HasForeignKey<Vivod>(v => v.TableId); // Указание внешнего ключа

            base.OnModelCreating(modelBuilder);
        }
    }
}
