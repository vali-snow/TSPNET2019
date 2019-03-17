using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace ServiceAutoClassLibrary.Repositories
{
    internal class ClientRepository : Repository<Client>, IClientRepository
    {
        public ClientRepository(DbContext context) : base(context)
        {
        }

        public IEnumerable<Comanda> GetComenziOfClient(int CustomerId)
        {
            return Set.Find(CustomerId).Autoturisme.SelectMany(a => a.Comenzi).ToList();
        }
    }
}