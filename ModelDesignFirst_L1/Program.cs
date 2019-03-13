using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelDesignFirst_L1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test Model Designer First");
            TestClient();
        }

        private static void TestClient()
        {
            using (Model1Container context = new Model1Container())
            {
                Client c = new Client()
                {
                    Nume = "AAA",
                    Prenume = "BBB",
                    Adresa = "Strada Eternitatii nr. 1H",
                    Judet = "A",
                    Localitate = "A",
                    Email = "a@a.com",
                    Telefon = "0770777777",
                    Autoturisme = null
                };
                context.Clienti.Add(c);
                context.SaveChanges();
                var clients = context.Clienti;
                foreach (var cl in clients)
                {
                    Console.WriteLine($"{cl.Nume} - {cl.Prenume}");
                }
            }
        }
    }
}
