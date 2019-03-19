using System.Data.Entity;

namespace ServiceAutoClassLibrary.Repositories
{
    /// <summary>
    /// Implementation of additional Sasiu repository operations
    /// </summary>
    internal class SasiuRepository : Repository<Sasiu>, ISasiuRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"></param>
        internal SasiuRepository(DbContext context) : base(context)
        {
        }
    }
}