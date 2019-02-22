using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public partial class AgendaForm : Form
    {
        private BindingList<AgendaItem> db { get; set; }
        public AgendaForm()
        {
            InitializeComponent();
            db = new BindingList<AgendaItem>() { new AgendaItem("Test", "Test", 50) };
            dgwAgenda.DataSource = db;
        }

        public AgendaForm(BindingList<AgendaItem> fakeDb): base()
        {
            db = fakeDb;
        }

        private void btnAddNewContact_Click(object sender, EventArgs e)
        {
            //validari pt save later
            //in caz de invalidari: MessageBox.Show("asd");
            db.Add(new AgendaItem(txtNume.Text, txtPrenume.Text, int.Parse(txtVarsta.Text), txtTelefon.Text, txtEmail.Text));
            clearForm();
        }

        private void btnClearForm_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void clearForm() {
            txtNume.Text = "";
            txtPrenume.Text = "";
            txtVarsta.Text = "";
            txtTelefon.Text = "";
            txtEmail.Text = "";
        }
    }
}
