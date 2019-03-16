using System.Data.Entity;

namespace ServiceAutoClassLibrary.Repositories
{
    internal class ClientRepository : Repository<Client>, IClientRepository
    {
        public ClientRepository(DbContext context) : base(context)
        {
        }
    }
}