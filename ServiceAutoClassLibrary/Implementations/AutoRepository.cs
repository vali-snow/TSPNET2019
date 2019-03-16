using System.Data.Entity;

namespace ServiceAutoClassLibrary.Repositories
{
    public class AutoRepository : Repository<Auto>, IAutoRepository
    {
        public AutoRepository(DbContext context) : base(context)
        {
        }
    }
}
