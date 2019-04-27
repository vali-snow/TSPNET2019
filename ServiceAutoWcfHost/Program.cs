using ServiceAutoWcfServiceLibrary;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServiceAutoWcfHost
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var hosts = new List<ServiceHost>() {
                new ServiceHost(typeof(SAAuto)),
                new ServiceHost(typeof(SAClient)),
                new ServiceHost(typeof(SAComanda)),
                new ServiceHost(typeof(SADetaliiComanda)),
                new ServiceHost(typeof(SAImagine)),
                new ServiceHost(typeof(SAMaterial)),
                new ServiceHost(typeof(SAMecanic)),
                new ServiceHost(typeof(SAOperatie)),
                new ServiceHost(typeof(SASasiu)),
            };
                foreach (var host in hosts)
                {
                    host.Open();
                }

                Console.WriteLine("Hit any key to exit");
                Console.ReadKey();

                foreach (var host in hosts)
                {
                    host.Close();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            
        }
    }
}
