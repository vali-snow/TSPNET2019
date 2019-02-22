using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    public class AgendaItem
    {
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public int Varsta { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public AgendaItem(string n, string p, int v, string t = "", string e = "")
        {
            Nume = n;
            Prenume = p;
            Varsta = v;
            Telefon = t;
            Email = e;
        }
    }
}
