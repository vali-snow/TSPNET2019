using System.Data.Entity;

namespace ServiceAutoClassLibrary.Repositories
{
    internal class DetaliiComandaRepository : Repository<DetaliiComanda>, IDetaliiComandaRepository
    {
        public DetaliiComandaRepository(DbContext context) : base(context)
        {
        }
    }
}