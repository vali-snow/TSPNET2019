namespace L7EFCodeFirst
{
    using L7EFCodeFirst.ModelClasses;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ModelPhotographs : DbContext
    {
        public DbSet<Photograph> Photographs { get; set; }
        public DbSet<PhotographFullImage> PhotographsFullImage { get; set; }

        public ModelPhotographs() : base("name=ModelPhotographs")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Photograph>()
                .HasRequired(p => p.PhotographFullImage)
                .WithRequiredPrincipal(p => p.Photograph);
            modelBuilder.Entity<Photograph>().ToTable("Photograph", "BazaDeDate");
            modelBuilder.Entity<PhotographFullImage>().ToTable("Photograph", "BazaDeDate");
        }
    }

}