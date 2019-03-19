using System.Data.Entity;

namespace ServiceAutoClassLibrary.Repositories
{
    /// <summary>
    /// Implementation of additional Operatie repository operations
    /// </summary>
    internal class OperatieRepository : Repository<Operatie>, IOperatieRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"></param>
        internal OperatieRepository(DbContext context) : base(context)
        {
        }
    }
}