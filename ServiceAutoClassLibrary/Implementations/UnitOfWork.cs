using System.Data.Entity;

namespace ServiceAutoClassLibrary.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext _context;
        public IAutoRepository Autoturisme { get; private set; }
        public IClientRepository Clienti { get; private set; }
        public IComandaRepository Comenzi { get; private set; }
        public IDetaliiComandaRepository DetaliiComenzi { get; private set; }
        public IImagineRepository Imagini { get; private set; }
        public IMaterialRepository Materiale { get; private set; }
        public IMecanicRepository Mecanici { get; private set; }
        public IOperatieRepository Operatii { get; private set; }
        public ISasiuRepository Sasiuri { get; private set; }

        public UnitOfWork(DbContext context)
        {
            _context = context;
            Autoturisme = new AutoRepository(_context);
            Clienti = new ClientRepository(_context);
            Comenzi = new ComandaRepository(_context);
            DetaliiComenzi = new DetaliiComandaRepository(_context);
            Imagini = new ImagineRepository(_context);
            Materiale = new MaterialRepository(_context);
            Mecanici = new MecanicRepository(_context);
            Operatii = new OperatieRepository(_context);
            Sasiuri = new SasiuRepository(_context);
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
