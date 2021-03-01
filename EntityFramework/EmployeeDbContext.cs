using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext()
            : base("DBConnection")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<EmployeeDbContext, Migrations.Configuration>());
        }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new EmployeeConfiguration());
        }
    }
}
