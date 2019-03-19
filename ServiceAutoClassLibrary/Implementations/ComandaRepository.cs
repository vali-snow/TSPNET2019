using System.Data.Entity;

namespace ServiceAutoClassLibrary.Repositories
{
    /// <summary>
    /// Implementation of additional Comanda repository operations
    /// </summary>
    internal class ComandaRepository : Repository<Comanda>, IComandaRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"></param>
        internal ComandaRepository(DbContext context) : base(context)
        {
        }
    }
}