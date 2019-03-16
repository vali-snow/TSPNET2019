using System.Data.Entity;

namespace ServiceAutoClassLibrary.Repositories
{
    internal class SasiuRepository : Repository<Sasiu>, ISasiuRepository
    {
        public SasiuRepository(DbContext context) : base(context)
        {
        }
    }
}