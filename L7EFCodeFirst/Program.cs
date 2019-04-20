using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using L7EFCodeFirst.ModelClasses;

namespace L7EFCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            TestScenario5();
        }

        /// <summary>
        /// O tabela ce se autoreferentiaza
        /// </summary>
        private static void TestScenario1()
        {
            using (var db = new ModelSelfRefrences())
            {
                db.SelfReferences.RemoveRange(db.SelfReferences);
                db.SaveChanges();

                var alfa = db.SelfReferences.ToList();

                var first = new SelfReference("SR1");
                var second = new SelfReference("SR2");
                var third = new SelfReference("SR3");
                var fourth = new SelfReference("SR4");
                var fifth = new SelfReference("SR5");
                second.AddReference(new List<SelfReference>() { third, fourth, fifth });
                first.AddReference(new List<SelfReference>() { second });

                db.SelfReferences.AddRange(new List<SelfReference>() { first });
                db.SaveChanges();

                var omega = db.SelfReferences.ToList();

                var leafs = db.SelfReferences.Where(sr => sr.References.Count == 0).ToList();
            }
        }

        /// <summary>
        /// Doua tabele ce partajeaza aceeasi cheie primara
        /// </summary>
        private static void TestScenario2()
        {
            using (var db = new ModelProducts())
            {
                var product = new Product
                {
                    SKU = 147,
                    Description = "Expandable Hydration Pack",
                    Price = 19.97M,
                    ImageURL = "/pack147.jpg"
                };
                db.Products.Add(product);
                product = new Product
                {
                    SKU = 178,
                    Description = "Rugged Ranger Duffel Bag",
                    Price = 39.97M,
                    ImageURL = "/pack178.jpg"
                };
                db.Products.Add(product);
                product = new Product
                {
                    SKU = 186,
                    Description = "Range Field Pack",
                    Price = 98.97M,
                    ImageURL = "/noimage.jp"
                };
                db.Products.Add(product);
                product = new Product
                {
                    SKU = 202,
                    Description = "Small Deployment Back Pack",
                    Price = 29.97M,
                    ImageURL = "/pack202.jpg"
                };
                db.Products.Add(product);
                db.SaveChanges();

                foreach (var p in db.Products)
                {
                    Console.WriteLine("{0} {1} {2} {3}", p.SKU, p.Description,
                    p.Price.ToString("C"), p.ImageURL);
                }
            }
        }

        /// <summary>
        /// Mai multe entitati pentru aceeasi tabela
        /// </summary>
        private static void TestScenario3()
        {
            byte[] thumbBits = new byte[100];
            byte[] fullBits = new byte[2000];

            using (var db = new ModelPhotographs())
            {
                var photo = new Photograph
                {
                    Title = "My Dog",
                    ThumbnailBits = thumbBits
                };
                var fullImage = new PhotographFullImage
                {
                    HighResolutionBits =
                fullBits
                };
                photo.PhotographFullImage = fullImage;
                db.Photographs.Add(photo);
                db.SaveChanges();

                foreach (var ph in db.Photographs)
                {
                    Console.WriteLine($"Photo: {ph.Title}, ThumbnailSize {ph.ThumbnailBits.Length} bytes");
                    // explicitly load the "expensive" entity,
                    db.Entry(ph).Reference(p => p.PhotographFullImage).Load();
                    Console.WriteLine($"Full Image Size: {photo.PhotographFullImage.HighResolutionBits.Length} bytes");
                }
            }
        }

        /// <summary>
        /// Modelare tabela prin mostenire tip
        /// </summary>
        private static void TestScenario4()
        {
            using (var db = new ModelBusiness())
            {
                var business = new Business
                {
                    Name = "Corner Dry Cleaning",
                    LicenseNumber = "100x1"
                };
                db.Businesses.Add(business);
                var retail = new Retail
                {
                    Name = "Shop and Save",
                    LicenseNumber = "200C",
                    Address = "101 Main",
                    City = "Anytown",
                    State = "TX",
                    ZIPCode = "76106"
                };
                db.Businesses.Add(retail);
                var web = new eCommerce
                {
                    Name = "BuyNow.com",
                    LicenseNumber = "300AB",
                    URL = "www.buynow.com"
                };
                db.Businesses.Add(web);
                db.SaveChanges();

                Console.WriteLine("\n--- All Businesses ---");
                foreach (var b in db.Businesses)
                {
                    Console.WriteLine("{0} (#{1})", b.Name, b.LicenseNumber);
                }

                Console.WriteLine("\n--- Retail Businesses ---");
                foreach (var r in db.Businesses.OfType<Retail>())
                {
                    Console.WriteLine("{0} (#{1})", r.Name, r.LicenseNumber);
                    Console.WriteLine("{0}", r.Address);
                    Console.WriteLine("{0}, {1} {2}", r.City, r.State, r.ZIPCode);
                }

                Console.WriteLine("\n--- eCommerce Businesses ---");
                foreach (var e in db.Businesses.OfType<eCommerce>())
                {
                    Console.WriteLine("{0} (#{1})", e.Name, e.LicenseNumber);
                    Console.WriteLine("Online address is: {0}", e.URL);
                }
            }
        }

        /// <summary>
        /// Modelare tabela folosind mostenire ierarhie
        /// </summary>
        private static void TestScenario5()
        {
            using (var db = new ModelEmployees())
            {
                var fte = new FullTimeEmployee
                {
                    FirstName = "Jane",
                    LastName = "Doe",
                    Salary = 71500M
                };
                db.Employees.Add(fte);
                fte = new FullTimeEmployee
                {
                    FirstName = "John",
                    LastName = "Smith",
                    Salary = 62500M
                };
                db.Employees.Add(fte);
                var hourly = new HourlyEmployee
                {
                    FirstName = "Tom",
                    LastName = "Jones",
                    Wage = 8.75M
                };
                db.Employees.Add(hourly);
                db.SaveChanges();

                Console.WriteLine("--- All Employees ---");
                foreach (var emp in db.Employees)
                {
                    bool fullTime = emp is HourlyEmployee ? false : true;
                    Console.WriteLine("{0} {1} ({2})", emp.FirstName, emp.LastName,
                    fullTime ? "Full Time" : "Hourly");
                }

                Console.WriteLine("--- Full Time ---");
                foreach (var full in db.Employees.OfType<FullTimeEmployee>())
                {
                    Console.WriteLine("{0} {1}", full.FirstName, full.LastName);
                }

                Console.WriteLine("--- Hourly ---");
                foreach (var hly in db.Employees.OfType<HourlyEmployee>())
                {
                    Console.WriteLine("{0} {1}", hly.FirstName, hly.LastName);
                }
            }
        }
    }
}
