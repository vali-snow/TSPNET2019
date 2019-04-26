using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using ServiceAutoClassLibrary;
using ServiceAutoClassLibrary.Repositories;

namespace ServiceAutoWcfServiceLibrary
{
    [ServiceBehavior(InstanceContextMode =InstanceContextMode.PerCall)]
    public class SAService : ISAService, IDisposable
    {
        private UnitOfWork uow { get; set; }

        public SAService()
        {
            uow = new UnitOfWork();
        }

        public void Add(Client entity)
        {
            uow.Clienti.Add(entity);
        }

        public void AddRange(IEnumerable<Client> entities)
        {
            uow.Clienti.AddRange(entities);
        }

        public IEnumerable<Client> GetAll()
        {
            return uow.Clienti.GetAll();
        }

        public Client GetById(int id)
        {
            return uow.Clienti.GetById(id);
        }

        public IEnumerable<Client> GetFiltered(Expression<Func<Client, bool>> predicate)
        {
            return uow.Clienti.GetFiltered(predicate);
        }

        public void Remove(Client entity)
        {
            uow.Clienti.Remove(entity);
        }

        public void RemoveRange(IEnumerable<Client> entities)
        {
            uow.Clienti.RemoveRange(entities);
        }

        public void Dispose()
        {
            uow.Dispose();
        }
    }
}
