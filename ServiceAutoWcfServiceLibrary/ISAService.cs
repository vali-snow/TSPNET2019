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
        IEnumerable<T> GetFiltered(Expression<Func<T, bool>> predicate);

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
    public interface ISAService: IGenericService<Client>
    {
    }
}
