using System.Data.Entity;

namespace ServiceAutoClassLibrary.Repositories
{
    internal class MaterialRepository : Repository<Material>, IMaterialRepository
    {
        public MaterialRepository(DbContext context) : base(context)
        {
        }
    }
}