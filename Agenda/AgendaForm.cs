using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public partial class AgendaForm : Form
    {
        private BindingList<AgendaItem> db { get; set; }
        private AgendaItem selectedContact { get; set; }

        public AgendaForm()
        {
            InitializeComponent();
            db = new BindingList<AgendaItem>();
            dgwAgenda.DataSource = db;
            btnDeleteRow.Enabled = false;
            btnModifyRow.Enabled = false;
        }

        public AgendaForm(BindingList<AgendaItem> fakeDb): this()
        {
            foreach (var contact in fakeDb)
            {
                db.Add(contact);
            }
        }

        private void btnAddNewContact_Click(object sender, EventArgs e)
        {
            //validari pt save later
            //in caz de invalidari: MessageBox.Show("asd");
            db.Add(new AgendaItem(txtNumeAdd.Text, txtPrenumeAdd.Text, int.Parse(txtVarstaAdd.Text), txtTelefonAdd.Text, txtEmailAdd.Text));
            clearForm();
        }

        private void btnClearFormAdd_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void clearForm() {
            txtNumeAdd.Text = "";
            txtPrenumeAdd.Text = "";
            txtVarstaAdd.Text = "";
            txtTelefonAdd.Text = "";
            txtEmailAdd.Text = "";
        }

        private void btnModifyRow_Click(object sender, EventArgs e)
        {
            selectedContact = db[dgwAgenda.SelectedRows[0].Index];
            txtNumeMod.Text = selectedContact.Nume;
            txtPrenumeMod.Text = selectedContact.Prenume;
            txtVarstaMod.Text = selectedContact.Varsta.ToString();
            txtTelefonMod.Text = selectedContact.Telefon;
            txtEmailMod.Text = selectedContact.Email;
            grbModifyContact.Visible = true;
        }


        private void btnDeleteRow_Click(object sender, EventArgs e)
        {
            db.RemoveAt(dgwAgenda.SelectedRows[0].Index);
        }

        private void dgwAgenda_SelectionChanged(object sender, EventArgs e)
        {
            var selectedRowCount = dgwAgenda.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount == 1)
            {
                btnDeleteRow.Enabled = true;
                btnModifyRow.Enabled = true;
            }
            else
            {
                btnDeleteRow.Enabled = false;
                btnModifyRow.Enabled = false;
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            //validari pt modify later
            //in caz de invalidari: MessageBox.Show("asd");
            var contactToModify = db.Single(o => o.Id == selectedContact.Id);
            contactToModify.Nume = txtNumeMod.Text;
            contactToModify.Prenume = txtPrenumeMod.Text;
            contactToModify.Varsta = int.Parse(txtVarstaMod.Text);
            contactToModify.Telefon = txtTelefonMod.Text;
            contactToModify.Email = txtEmailMod.Text;
            db.ResetBindings();
            selectedContact = null;
            txtNumeMod.Text = "";
            txtPrenumeMod.Text = "";
            txtVarstaMod.Text = "";
            txtTelefonMod.Text = "";
            txtEmailMod.Text = "";
            grbModifyContact.Visible = false;
        }

        private void btnCloseMod_Click(object sender, EventArgs e)
        {
            selectedContact = null;
            txtNumeMod.Text = "";
            txtPrenumeMod.Text = "";
            txtVarstaMod.Text = "";
            txtTelefonMod.Text = "";
            txtEmailMod.Text = "";
            grbModifyContact.Visible = false;
        }

        private void btnSaveToDb_Click(object sender, EventArgs e)
        {
            using (StreamWriter file = new StreamWriter($"..\\..\\db\\db.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, db);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
