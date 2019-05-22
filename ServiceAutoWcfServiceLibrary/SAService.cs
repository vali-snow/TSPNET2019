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
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class SAAuto : ISAAuto
    {
        private UnitOfWork uow { get; set; }

        public SAAuto()
        {
            uow = new UnitOfWork();
        }

        public Auto GetById(int id)
        {
            return uow.Autoturisme.GetById(id);
        }

        public IEnumerable<Auto> GetAll()
        {
            return uow.Autoturisme.GetAll();
        }

        public void Add(Auto entity)
        {
            uow.Autoturisme.Add(entity);
            uow.Complete();
        }

        public void AddRange(IEnumerable<Auto> entities)
        {
            uow.Autoturisme.AddRange(entities);
            uow.Complete();
        }

        public void Modify(Auto entity)
        {
            var auto = uow.Autoturisme.GetById(entity.AutoId);
            if (auto.NumarAuto != entity.NumarAuto) { auto.NumarAuto = entity.NumarAuto; }
            if (auto.SasiuId != entity.SasiuId)
            {
                auto.SasiuId = entity.SasiuId;
                auto.Sasiu = uow.Sasiuri.GetById(entity.SasiuId);
            }
            if (auto.SerieSasiu != entity.SerieSasiu) { auto.SerieSasiu = entity.SerieSasiu; }
            if (auto.ClientId != entity.ClientId)
            {
                auto.ClientId = entity.ClientId;
                auto.Client = uow.Clienti.GetById(entity.ClientId);
            }
            uow.Complete();
        }

        public void Remove(Auto entity)
        {
            uow.Autoturisme.Remove(entity);
            uow.Complete();
        }

        public void RemoveRange(IEnumerable<Auto> entities)
        {
            uow.Autoturisme.RemoveRange(entities);
            uow.Complete();
        }

        public void Dispose()
        {
            uow.Dispose();
        }
    }

    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class SAClient : ISAClient
    {
        private UnitOfWork uow { get; set; }

        public SAClient()
        {
            uow = new UnitOfWork();
        }

        public Client GetById(int id)
        {
            return uow.Clienti.GetById(id);
        }

        public IEnumerable<Client> GetAll()
        {
            return uow.Clienti.GetAll();
        }

        public void Add(Client entity)
        {
            uow.Clienti.Add(entity);
            uow.Complete();
        }

        public void AddRange(IEnumerable<Client> entities)
        {
            uow.Clienti.AddRange(entities);
            uow.Complete();
        }

        public void Modify(Client entity)
        {
            var client = uow.Clienti.GetById(entity.ClientId);
            if (client.Nume != entity.Nume) { client.Nume = entity.Nume; }
            if (client.Prenume != entity.Prenume) { client.Prenume = entity.Prenume; }
            if (client.Adresa != entity.Adresa) { client.Adresa = entity.Adresa; }
            if (client.Localitate != entity.Localitate) { client.Localitate = entity.Localitate; }
            if (client.Judet != entity.Judet) { client.Judet = entity.Judet; }
            if (client.Telefon != entity.Telefon) { client.Telefon = entity.Telefon; }
            if (client.Email != entity.Email) { client.Email = entity.Email; }
            uow.Complete();
        }

        public void Remove(Client entity)
        {
            uow.Clienti.Remove(entity);
            uow.Complete();
        }

        public void RemoveRange(IEnumerable<Client> entities)
        {
            uow.Clienti.RemoveRange(entities);
            uow.Complete();
        }

        public void Dispose()
        {
            uow.Dispose();
        }
    }

    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class SAComanda : ISAComanda
    {
        private UnitOfWork uow { get; set; }

        public SAComanda()
        {
            uow = new UnitOfWork();
        }

        public Comanda GetById(int id)
        {
            return uow.Comenzi.GetById(id);
        }

        public IEnumerable<Comanda> GetAll()
        {
            return uow.Comenzi.GetAll();
        }

        public void Add(Comanda entity)
        {
            uow.Comenzi.Add(entity);
            uow.Complete();
        }

        public void AddRange(IEnumerable<Comanda> entities)
        {
            uow.Comenzi.AddRange(entities);
            uow.Complete();
        }

        public void Modify(Comanda entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(Comanda entity)
        {
            uow.Comenzi.Remove(entity);
            uow.Complete();
        }

        public void RemoveRange(IEnumerable<Comanda> entities)
        {
            uow.Comenzi.RemoveRange(entities);
            uow.Complete();
        }

        public void Dispose()
        {
            uow.Dispose();
        }
    }

    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class SADetaliiComanda : ISADetaliiComanda
    {
        private UnitOfWork uow { get; set; }

        public SADetaliiComanda()
        {
            uow = new UnitOfWork();
        }

        public DetaliiComanda GetById(int id)
        {
            return uow.DetaliiComenzi.GetById(id);
        }

        public IEnumerable<DetaliiComanda> GetAll()
        {
            return uow.DetaliiComenzi.GetAll();
        }

        public void Add(DetaliiComanda entity)
        {
            uow.DetaliiComenzi.Add(entity);
            uow.Complete();
        }

        public void AddRange(IEnumerable<DetaliiComanda> entities)
        {
            uow.DetaliiComenzi.AddRange(entities);
            uow.Complete();
        }

        public void Remove(DetaliiComanda entity)
        {
            uow.DetaliiComenzi.Remove(entity);
            uow.Complete();
        }

        public void RemoveRange(IEnumerable<DetaliiComanda> entities)
        {
            uow.DetaliiComenzi.RemoveRange(entities);
            uow.Complete();
        }

        public void Dispose()
        {
            uow.Dispose();
        }

        public void Modify(DetaliiComanda entity)
        {
            throw new NotImplementedException();
        }
    }

    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class SAImagine : ISAImagine
    {
        private UnitOfWork uow { get; set; }

        public SAImagine()
        {
            uow = new UnitOfWork();
        }

        public Imagine GetById(int id)
        {
            return uow.Imagini.GetById(id);
        }

        public IEnumerable<Imagine> GetAll()
        {
            return uow.Imagini.GetAll();
        }

        public void Add(Imagine entity)
        {
            uow.Imagini.Add(entity);
            uow.Complete();
        }

        public void AddRange(IEnumerable<Imagine> entities)
        {
            uow.Imagini.AddRange(entities);
            uow.Complete();
        }

        public void Remove(Imagine entity)
        {
            uow.Imagini.Remove(entity);
            uow.Complete();
        }

        public void RemoveRange(IEnumerable<Imagine> entities)
        {
            uow.Imagini.RemoveRange(entities);
            uow.Complete();
        }

        public void Dispose()
        {
            uow.Dispose();
        }

        public void Modify(Imagine entity)
        {
            throw new NotImplementedException();
        }
    }

    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class SAMaterial : ISAMaterial
    {
        private UnitOfWork uow { get; set; }

        public SAMaterial()
        {
            uow = new UnitOfWork();
        }

        public Material GetById(int id)
        {
            return uow.Materiale.GetById(id);
        }

        public IEnumerable<Material> GetAll()
        {
            return uow.Materiale.GetAll();
        }

        public void Add(Material entity)
        {
            uow.Materiale.Add(entity);
            uow.Complete();
        }

        public void AddRange(IEnumerable<Material> entities)
        {
            uow.Materiale.AddRange(entities);
            uow.Complete();
        }

        public void Remove(Material entity)
        {
            uow.Materiale.Remove(entity);
            uow.Complete();
        }

        public void RemoveRange(IEnumerable<Material> entities)
        {
            uow.Materiale.RemoveRange(entities);
            uow.Complete();
        }

        public void Dispose()
        {
            uow.Dispose();
        }

        public void Modify(Material entity)
        {
            throw new NotImplementedException();
        }
    }

    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class SAMecanic : ISAMecanic
    {
        private UnitOfWork uow { get; set; }

        public SAMecanic()
        {
            uow = new UnitOfWork();
        }

        public Mecanic GetById(int id)
        {
            return uow.Mecanici.GetById(id);
        }

        public IEnumerable<Mecanic> GetAll()
        {
            return uow.Mecanici.GetAll();
        }

        public void Add(Mecanic entity)
        {
            uow.Mecanici.Add(entity);
            uow.Complete();
        }

        public void AddRange(IEnumerable<Mecanic> entities)
        {
            uow.Mecanici.AddRange(entities);
            uow.Complete();
        }

        public void Remove(Mecanic entity)
        {
            uow.Mecanici.Remove(entity);
            uow.Complete();
        }

        public void RemoveRange(IEnumerable<Mecanic> entities)
        {
            uow.Mecanici.RemoveRange(entities);
            uow.Complete();
        }

        public void Dispose()
        {
            uow.Dispose();
        }

        public void Modify(Mecanic entity)
        {
            throw new NotImplementedException();
        }
    }

    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class SAOperatie : ISAOperatie
    {
        private UnitOfWork uow { get; set; }

        public SAOperatie()
        {
            uow = new UnitOfWork();
        }

        public Operatie GetById(int id)
        {
            return uow.Operatii.GetById(id);
        }

        public IEnumerable<Operatie> GetAll()
        {
            return uow.Operatii.GetAll();
        }

        public void Add(Operatie entity)
        {
            uow.Operatii.Add(entity);
            uow.Complete();
        }

        public void AddRange(IEnumerable<Operatie> entities)
        {
            uow.Operatii.AddRange(entities);
            uow.Complete();
        }

        public void Remove(Operatie entity)
        {
            uow.Operatii.Remove(entity);
            uow.Complete();
        }

        public void RemoveRange(IEnumerable<Operatie> entities)
        {
            uow.Operatii.RemoveRange(entities);
            uow.Complete();
        }

        public void Dispose()
        {
            uow.Dispose();
        }

        public void Modify(Operatie entity)
        {
            throw new NotImplementedException();
        }
    }

    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class SASasiu : ISASasiu
    {
        private UnitOfWork uow { get; set; }

        public SASasiu()
        {
            uow = new UnitOfWork();
        }

        public Sasiu GetById(int id)
        {
            return uow.Sasiuri.GetById(id);
        }

        public IEnumerable<Sasiu> GetAll()
        {
            return uow.Sasiuri.GetAll();
        }

        public void Add(Sasiu entity)
        {
            uow.Sasiuri.Add(entity);
            uow.Complete();
        }

        public void AddRange(IEnumerable<Sasiu> entities)
        {
            uow.Sasiuri.AddRange(entities);
            uow.Complete();
        }

        public void Remove(Sasiu entity)
        {
            uow.Sasiuri.Remove(entity);
            uow.Complete();
        }

        public void RemoveRange(IEnumerable<Sasiu> entities)
        {
            uow.Sasiuri.RemoveRange(entities);
            uow.Complete();
        }

        public void Dispose()
        {
            uow.Dispose();
        }

        public void Modify(Sasiu entity)
        {
            throw new NotImplementedException();
        }
    }
}
