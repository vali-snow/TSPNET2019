using System.Data.Entity;

namespace ServiceAutoClassLibrary.Repositories
{
    /// <summary>
    /// Implementation of additional Imagine repository operations
    /// </summary>
    internal class ImagineRepository : Repository<Imagine>, IImagineRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"></param>
        internal ImagineRepository(DbContext context) : base(context)
        {
        }
    }
}