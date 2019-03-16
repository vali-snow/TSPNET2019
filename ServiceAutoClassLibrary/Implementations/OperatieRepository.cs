using System.Data.Entity;

namespace ServiceAutoClassLibrary.Repositories
{
    internal class OperatieRepository : Repository<Operatie>, IOperatieRepository
    {
        public OperatieRepository(DbContext context) : base(context)
        {
        }
    }
}