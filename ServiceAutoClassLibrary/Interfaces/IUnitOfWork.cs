using System;

namespace ServiceAutoClassLibrary.Repositories
{
    /// <summary>
    /// Interface for the unit of work
    /// </summary>
    public interface IUnitOfWork: IDisposable
    {
        IAutoRepository Autoturisme { get; }
        IClientRepository Clienti { get; }
        IComandaRepository Comenzi { get; }
        IDetaliiComandaRepository DetaliiComenzi { get; }
        IImagineRepository Imagini { get; }
        IMaterialRepository Materiale { get; }
        IMecanicRepository Mecanici { get; }
        IOperatieRepository Operatii { get; }
        ISasiuRepository Sasiuri { get; }

        int Complete();
    }
}
