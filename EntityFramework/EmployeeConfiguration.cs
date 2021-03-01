using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    class EmployeeConfiguration:EntityTypeConfiguration<Employee>
    {
        public EmployeeConfiguration()
        {
            ToTable("Employee");
            HasKey(d => d.Guid);
            Property(d => d.Guid).HasColumnName("ID").IsRequired();
            Property(d => d.Name).HasColumnName("Name").IsRequired();
            Property(d => d.Surname).HasColumnName("Surname").IsRequired();
            Property(d => d.Middlename).HasColumnName("Middle name");
            Property(d => d.Position).HasColumnName("Position").IsRequired();
            Property(d => d.Department).HasColumnName("Department").IsRequired();
            Property(d => d.Salary).HasColumnName("Salary").IsRequired();
        }
    }
}
