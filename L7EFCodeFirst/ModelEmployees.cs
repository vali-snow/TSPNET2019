namespace L7EFCodeFirst
{
    using L7EFCodeFirst.ModelClasses;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ModelEmployees : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public ModelEmployees(): base("name=ModelEmployees")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Employee>()
                .Map<FullTimeEmployee>(m => m.Requires("EmployeeType").HasValue(1))
                .Map<HourlyEmployee>(m => m.Requires("EmployeeType").HasValue(2));
        }
    }
}