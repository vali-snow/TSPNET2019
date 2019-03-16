using System.Data.Entity;

namespace ServiceAutoClassLibrary.Repositories
{
    internal class ImagineRepository : Repository<Imagine>, IImagineRepository
    {
        public ImagineRepository(DbContext context) : base(context)
        {
        }
    }
}