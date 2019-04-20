namespace L7EFCodeFirst
{
    using L7EFCodeFirst.ModelClasses;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ModelBusiness : DbContext
    {
        public DbSet<Business> Businesses { get; set; }

        public ModelBusiness(): base("name=ModelBusiness")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}