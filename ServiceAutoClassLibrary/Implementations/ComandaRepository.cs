using System.Data.Entity;

namespace ServiceAutoClassLibrary.Repositories
{
    internal class ComandaRepository : Repository<Comanda>, IComandaRepository
    {
        public ComandaRepository(DbContext context) : base(context)
        {
        }
    }
}