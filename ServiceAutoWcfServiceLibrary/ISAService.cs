using ServiceAutoClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServiceAutoWcfServiceLibrary
{
    [ServiceContract]
    public interface IGenericService<T> where T : class
    {
        [OperationContract]
        T GetById(int id);

        [OperationContract]
        IEnumerable<T> GetAll();

        [OperationContract]
        void Add(T entity);

        [OperationContract]
        void AddRange(IEnumerable<T> entities);

        [OperationContract]
        void Remove(T entity);

        [OperationContract]
        void RemoveRange(IEnumerable<T> entities);
    }

    [ServiceContract]
    public interface ISAAuto : IGenericService<Auto> { }
    [ServiceContract]
    public interface ISAClient : IGenericService<Client> { }
    [ServiceContract]
    public interface ISAComanda : IGenericService<Comanda> { }
    [ServiceContract]
    public interface ISADetaliiComanda : IGenericService<DetaliiComanda> { }
    [ServiceContract]
    public interface ISAImagine : IGenericService<Imagine> { }
    [ServiceContract]
    public interface ISAMaterial : IGenericService<Material> { }
    [ServiceContract]
    public interface ISAMecanic : IGenericService<Mecanic> { }
    [ServiceContract]
    public interface ISAOperatie : IGenericService<Operatie> { }
    [ServiceContract]
    public interface ISASasiu : IGenericService<Sasiu> { }
}
