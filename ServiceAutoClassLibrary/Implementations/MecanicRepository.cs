using System.Data.Entity;

namespace ServiceAutoClassLibrary.Repositories
{
    /// <summary>
    /// Implementation of additional Mecanic repository operations
    /// </summary>
    internal class MecanicRepository : Repository<Mecanic>, IMecanicRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"></param>
        internal MecanicRepository(DbContext context) : base(context)
        {
        }
    }
}