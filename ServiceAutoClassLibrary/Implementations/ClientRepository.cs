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

        /// <summary>
        /// Alternate way of getting all the comenzi for one client
        /// </summary>
        /// <param name="CustomerId"></param>
        /// <returns></returns>
        public IEnumerable<Comanda> GetComenziOfClient(int CustomerId)
        {
            return set.Find(CustomerId).Autoturisme.SelectMany(a => a.Comenzi).ToList();
        }
    }
}