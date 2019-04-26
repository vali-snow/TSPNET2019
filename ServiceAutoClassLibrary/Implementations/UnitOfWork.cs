using System.Data.Entity;

namespace ServiceAutoClassLibrary.Repositories
{
    /// <summary>
    /// Implementation of unit of work
    /// </summary>
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext _context;

        /// <summary>
        /// Repository for Autoturisme
        /// </summary>
        public IAutoRepository Autoturisme { get; private set; }
        /// <summary>
        /// Repository for Clienti
        /// </summary>
        public IClientRepository Clienti { get; private set; }
        /// <summary>
        /// Repository for Comenzi
        /// </summary>
        public IComandaRepository Comenzi { get; private set; }
        /// <summary>
        /// Repository for DetaliiComenzi
        /// </summary>
        public IDetaliiComandaRepository DetaliiComenzi { get; private set; }
        /// <summary>
        /// Repository for Imagini
        /// </summary>
        public IImagineRepository Imagini { get; private set; }
        /// <summary>
        /// Repository for Materiale
        /// </summary>
        public IMaterialRepository Materiale { get; private set; }
        /// <summary>
        /// Repository for Mecanici
        /// </summary>
        public IMecanicRepository Mecanici { get; private set; }
        /// <summary>
        /// Repository for Operatii
        /// </summary>
        public IOperatieRepository Operatii { get; private set; }
        /// <summary>
        /// Repository for Sasiuri
        /// </summary>
        public ISasiuRepository Sasiuri { get; private set; }

        public UnitOfWork()
        {
            _context = new ServiceAutoModelContainer();
            InstantiateRepositories();
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context">to receive a ServiceAutoModelContainer context</param>
        public UnitOfWork(DbContext context)
        {
            _context = context;
            InstantiateRepositories();
        }

        private void InstantiateRepositories()
        {
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

        /// <summary>
        /// Method marking the end of a transaction
        /// </summary>
        /// <returns></returns>
        public int Complete()
        {
            return _context.SaveChanges();
        }

        /// <summary>
        /// Method to release the held resource
        /// </summary>
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
