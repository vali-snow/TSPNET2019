using System.Collections.Generic;

namespace ServiceAutoClassLibrary.Repositories
{
    public interface IClientRepository : IRepository<Client>
    {
        IEnumerable<Comanda> GetComenziOfClient(int CustomerId);
    }
}