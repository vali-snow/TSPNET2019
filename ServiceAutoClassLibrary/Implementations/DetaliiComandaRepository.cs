using System.Data.Entity;

namespace ServiceAutoClassLibrary.Repositories
{
    /// <summary>
    /// Implementation of additional Detalii Comanda repository operations
    /// </summary>
    internal class DetaliiComandaRepository : Repository<DetaliiComanda>, IDetaliiComandaRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"></param>
        internal DetaliiComandaRepository(DbContext context) : base(context)
        {
        }
    }
}