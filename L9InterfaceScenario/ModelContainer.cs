namespace L9InterfaceScenario
{
    using L9InterfaceScenario.Classes;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Linq;

    public class ModelContainer : DbContext
    {
        public virtual DbSet<CustomerType> CustomerTypes { get; set; }

        public ModelContainer() : base("name=ModelContainer")
        {
            (this as IObjectContextAdapter).ObjectContext.ObjectMaterialized += (sender, args) =>
                {
                    if (args.Entity is IObjectWithState entity)
                    {
                        entity.State = State.Unchanged;
                    }
                };        }
    }
}