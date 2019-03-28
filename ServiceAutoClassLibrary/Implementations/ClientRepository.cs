using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace ServiceAutoClassLibrary.Repositories
{
    /// <summary>
    /// Implementation of additional Client repository operations
    /// </summary>
    internal class ClientRepository : Repository<Client>, IClientRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"></param>
        internal ClientRepository(DbContext context) : base(context)
        {
        }
    }
}