using ServiceAutoClassLibrary;
using ServiceAutoClassLibrary.Repositories;

namespace ServiceAutoClassTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var unitOfWork = new UnitOfWork(new ServiceAutoModelContainer()))
            {
                var autoturisme = unitOfWork.Autoturisme.GetAll();
                var clienti = unitOfWork.Clienti.GetAll();
                var sasiuri = unitOfWork.Sasiuri.GetAll();
            }
        }
    }
}
