using System.Data.Entity;

namespace ServiceAutoClassLibrary.Repositories
{
    internal class MecanicRepository : Repository<Mecanic>, IMecanicRepository
    {
        public MecanicRepository(DbContext context) : base(context)
        {
        }
    }
}