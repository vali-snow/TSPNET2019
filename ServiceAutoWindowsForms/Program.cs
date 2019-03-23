using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServiceAutoClassLibrary;
using ServiceAutoClassLibrary.Repositories;

namespace ServiceAutoWindowsForms
{
    static class Program
    {
        internal static UnitOfWork UOW { get; set; }

        static Program()
        {
            UOW = new UnitOfWork(new ServiceAutoModelContainer());
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
