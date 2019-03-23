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
            new Clienti(uow).ShowDialog();
        }

        private void btnMainMenuExit_Click(object sender, EventArgs e)
        {
            uow.Dispose();
            this.Close();
        }
    }
}
