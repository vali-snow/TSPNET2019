using ServiceAutoClassLibrary;
using ServiceAutoClassLibrary.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceAutoWinForm
{
    public partial class MainPage : Form
    {
        private readonly UnitOfWork uow = new UnitOfWork(new ServiceAutoModelContainer());

        public MainPage()
        {
            InitializeComponent();
        }

        private void btnClienti_Click(object sender, EventArgs e)
        {
            using (var form = new Clienti(uow))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    OpenOnClose(uow, form.onCloseParameters);
                }
            }
        }

        private void btnAutoturisme_Click(object sender, EventArgs e)
        {
            using (var form = new Autoturisme(uow))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    OpenOnClose(uow, form.onCloseParameters);
                }
            }
        }

        private void btnSasiuri_Click(object sender, EventArgs e)
        {
            //using (var form = new Sasiuri(uow))
            //{
            //    if (form.ShowDialog() == DialogResult.OK)
            //    {
            //        OpenOnClose(uow, form.onCloseParameters);
            //    }
            //}
        }

        private void btnComenzi_Click(object sender, EventArgs e)
        {
            using (var form = new Comenzi(uow))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    OpenOnClose(uow, form.onCloseParameters);
                }
            }
        }

        private static void OpenOnClose(UnitOfWork uow, Dictionary<string,string> parameters)
        {
            switch (parameters["toOpen"])
            {
                case "Autoturisme":
                    using (var form = new Autoturisme(uow, parameters))
                    {
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            OpenOnClose(uow, form.onCloseParameters);
                        }
                    }
                    break;
                case "Comenzi":
                    using (var form = new Comenzi(uow, parameters))
                    {
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            OpenOnClose(uow, form.onCloseParameters);
                        }
                    }
                    break;
                default:
                    break;
            }
        }

        private void btnMainMenuExit_Click(object sender, EventArgs e)
        {
            uow.Dispose();
            this.Close();
        }        
    }
}
