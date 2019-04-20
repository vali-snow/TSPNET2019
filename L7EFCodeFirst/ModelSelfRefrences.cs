using L7EFCodeFirst.ModelClasses;
using System;
using System.Data.Entity;
using System.Linq;

namespace L7EFCodeFirst
{
    public class ModelSelfRefrences : DbContext
    {
        public virtual DbSet<SelfReference> SelfReferences { get; set; }

        public ModelSelfRefrences(): base("name=ModelSelfRefrences")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<SelfReference>()
                .HasMany(m => m.References)
                .WithOptional(m => m.ParentSelfReference);
        }
    }
}