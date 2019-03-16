using System;
using System.ComponentModel;

namespace Agenda
{
    public class AgendaItem
    {
        [Browsable(false)]
        public Guid Id { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public int Varsta { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public AgendaItem(string n, string p, int v, string t = "", string e = "")
        {
            Id = Guid.NewGuid();
            Nume = n;
            Prenume = p;
            Varsta = v;
            Telefon = t;
            Email = e;
        }
    }
}
