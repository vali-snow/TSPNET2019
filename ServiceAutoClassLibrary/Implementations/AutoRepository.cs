using System.Data.Entity;

namespace ServiceAutoClassLibrary.Repositories
{
    /// <summary>
    /// Implementation of additional Auto repository operations
    /// </summary>
    internal class AutoRepository : Repository<Auto>, IAutoRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"></param>
        internal AutoRepository(DbContext context) : base(context)
        {
        }
    }
}
