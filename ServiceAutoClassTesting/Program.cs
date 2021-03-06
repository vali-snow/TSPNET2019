﻿/// <summary>
/// Nume si prenume: Sarghi Valentin
/// Laborator: Joi 14-16
/// Tema laborator: Proiect TSP.Net - Partea I: Class Library
/// Data predare proiect: 21.03.2019
/// Declaratie: Acest proiect nu a fost copiat din alte surse. Pana la proba contrara, doresc sa beneficiez de prezumtia de nevinovatie.
/// Bibliografie, surse de inspiratie:
/// https://youtu.be/rYK0B1CQUN8
/// https://youtu.be/rtXpYpZdOzM
/// </summary>


using ServiceAutoClassLibrary;
using ServiceAutoClassLibrary.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ServiceAutoClassTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var unitOfWork = new UnitOfWork(new ServiceAutoModelContainer()))
            {
                SeedDB();
                //var client = unitOfWork.Clienti.GetAll().FirstOrDefault();
                //var comenzi1 = client.Comenzi;
                //var comenzi2 = unitOfWork.Clienti.GetComenziOfClient(client.ClientId);
            }
        }

        static void SeedDB()
        {
            using (var unitOfWork = new UnitOfWork(new ServiceAutoModelContainer()))
            {
                unitOfWork.Autoturisme.RemoveRange(unitOfWork.Autoturisme.GetAll());
                unitOfWork.Clienti.RemoveRange(unitOfWork.Clienti.GetAll());
                unitOfWork.Comenzi.RemoveRange(unitOfWork.Comenzi.GetAll());
                unitOfWork.DetaliiComenzi.RemoveRange(unitOfWork.DetaliiComenzi.GetAll());
                unitOfWork.Imagini.RemoveRange(unitOfWork.Imagini.GetAll());
                unitOfWork.Materiale.RemoveRange(unitOfWork.Materiale.GetAll());
                unitOfWork.Mecanici.RemoveRange(unitOfWork.Mecanici.GetAll());
                unitOfWork.Operatii.RemoveRange(unitOfWork.Operatii.GetAll());
                unitOfWork.Sasiuri.RemoveRange(unitOfWork.Sasiuri.GetAll());


                var client1 = new Client() { Nume = "S", Prenume = "Valentin", Adresa = "Str. X nr. 28A", Localitate = "Iasi", Judet = "Iasi", Telefon = "", Email = "" };
                var client2 = new Client() { Nume = "S", Prenume = "Ana", Adresa = "Str. X nr. 28A", Localitate = "Iasi", Judet = "Iasi", Telefon = "", Email = "" };

                var sasiu1 = new Sasiu() { CodSasiu = "FF", Denumire = "FF2009" };

                var autoturism1 = new Auto() { ClientId = client1.ClientId, Client = client1, NumarAuto = "NT24ALD", SasiuId = sasiu1.SasiuId, Sasiu = sasiu1, SerieSasiu = "FAKEFF2009" };
                var autoturism2 = new Auto() { ClientId = client1.ClientId, Client = client1, NumarAuto = "NT22ALD", SasiuId = sasiu1.SasiuId, Sasiu = sasiu1, SerieSasiu = "FAKEFF2011" };
                var autoturism3 = new Auto() { ClientId = client2.ClientId, Client = client2, NumarAuto = "NT20ALD", SasiuId = sasiu1.SasiuId, Sasiu = sasiu1, SerieSasiu = "FAKEFF2011" };

                var comanda1 = new Comanda() { AutoId = autoturism1.AutoId, ClientId = autoturism1.ClientId, Auto = autoturism1, Client = autoturism1.Client, DataFinalizare = DateTime.Now, DataProgramare = DateTime.Now, DataSystem = DateTime.Now, Descriere = "comanda1", KmBord = 100000, StareComanda = Stare.InAsteptare, ValoarePiese = 0 };
                var comanda2 = new Comanda() { AutoId = autoturism1.AutoId, ClientId = autoturism1.ClientId, Auto = autoturism1, Client = autoturism1.Client, DataFinalizare = DateTime.Now, DataProgramare = DateTime.Now, DataSystem = DateTime.Now, Descriere = "comanda1", KmBord = 120000, StareComanda = Stare.InAsteptare, ValoarePiese = 0 };
                var comanda3 = new Comanda() { AutoId = autoturism2.AutoId, ClientId = autoturism2.ClientId, Auto = autoturism2, Client = autoturism2.Client, DataFinalizare = DateTime.Now, DataProgramare = DateTime.Now, DataSystem = DateTime.Now, Descriere = "comanda1", KmBord = 50000, StareComanda = Stare.InAsteptare, ValoarePiese = 0 };

                unitOfWork.Clienti.AddRange(new List<Client>() { client1, client2 });
                unitOfWork.Sasiuri.Add(sasiu1);
                unitOfWork.Autoturisme.AddRange(new List<Auto>() { autoturism1, autoturism2, autoturism3});
                unitOfWork.Comenzi.AddRange(new List<Comanda>() { comanda1, comanda2, comanda3 });
                unitOfWork.Complete();
            }
        }
    }
} 
