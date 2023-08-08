using Microsoft.EntityFrameworkCore;
using MotoApp.Entities;

namespace MotoApp.Data
{
    public class MotoAppDbContext : DbContext
    {
        public DbSet<Employee> Employees => Set<Employee>();

        public DbSet<BusinessPartners> BusinessPartners => Set<BusinessPartners>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseInMemoryDatabase("StorageAppDb");
        }
    }
}
