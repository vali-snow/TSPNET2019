using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Agenda
{
    static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (File.Exists($"..\\..\\db.json"))
            {
                BindingList<AgendaItem> db;
                using (StreamReader file = new StreamReader($"..\\..\\db.json"))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    db = (BindingList<AgendaItem>)serializer.Deserialize(file, typeof(BindingList<AgendaItem>));
                }
                Application.Run(new AgendaForm(db));
            }
            else
            {
                Application.Run(new AgendaForm());
            }
        }
    }
}
