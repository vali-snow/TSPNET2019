using L9InterfaceScenario.Classes;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L9InterfaceScenario
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerType ct;
            using (var context = new ModelContainer())
            {
                //var c1 = new Customer() { Name = "1"};
                //var c2 = new Customer() { Name = "2"};
                //var newct = new CustomerType() { Description = "Preferat", Customers = new HashSet<Customer>() { c1,c2} };
                //context.CustomerTypes.Add(newct);
                context.SaveChanges();
                ct = (from d in context.CustomerTypes.Include(d => d.Customers)
                      where d.Description == "Preferat"
                      select d).SingleOrDefault();
            } // context distrus
            ct.Description = "Super preferat";
            ct.State = State.Modified;
            var firstCustomer = ct.Customers.First();
            firstCustomer.Name = "Alfa Omega srl";
            firstCustomer.State = State.Modified;
            var secondCustomer = ct.Customers.Last();
            secondCustomer.State = State.Deleted;
            ct.Customers.Add(new Customer
            {
                Name = "EON srl",
                State = State.Added
            });
            SaveCustomerTypeGraph(ct);
            //ApplyChanges<CustomerType>(ct);
        }

        public static EntityState ConvertState(State state)
        {
            switch (state)
            {
                case State.Added:
                    return EntityState.Added;
                case State.Modified:
                    return EntityState.Modified;
                case State.Deleted:
                    return EntityState.Deleted;
                default:
                    return EntityState.Unchanged;
            }
        }
        public static void SaveCustomerTypeGraph(CustomerType customerType)
        {
            using (var context = new ModelContainer())
            {
                context.CustomerTypes.Add(customerType);
                foreach (var entry in context.ChangeTracker.Entries<IObjectWithState>())
                {
                    IObjectWithState stateInfo = entry.Entity;
                    entry.State = ConvertState(stateInfo.State);
                }
                context.SaveChanges();
            }
        }

        private static void ApplyChanges<TEntity>(TEntity root) where TEntity : class, IObjectWithState
        {
            using (var context = new ModelContainer())
            {
                context.Set<TEntity>().Add(root);
                CheckForEntitiesWithoutStateInterface(context);
                foreach (var entry in context.ChangeTracker.Entries<IObjectWithState>())
                {
                    IObjectWithState stateInfo = entry.Entity;
                    entry.State = ConvertState(stateInfo.State);
                }
                context.SaveChanges();
            }
        }

        private static void CheckForEntitiesWithoutStateInterface(ModelContainer context)
        {
            var entitiesWithoutState = from e in context.ChangeTracker.Entries()
                                       where !(e.Entity is IObjectWithState)
                                       select e;
            if (entitiesWithoutState.Any())
            {
                throw new NotSupportedException("Toate entitatile trebuie sa implementeze IObjectWithState");
            }
        }
    }
}
