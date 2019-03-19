using System.Data.Entity;

namespace ServiceAutoClassLibrary.Repositories
{
    /// <summary>
    /// Implementation of additional Material repository operations
    /// </summary>
    internal class MaterialRepository : Repository<Material>, IMaterialRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"></param>
        internal MaterialRepository(DbContext context) : base(context)
        {
        }
    }
}