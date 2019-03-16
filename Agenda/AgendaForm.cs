using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Agenda
{
    public partial class AgendaForm : Form
    {
        private BindingList<AgendaItem> db { get; set; }
        private AgendaItem selectedContact { get; set; }
        private bool isDbModified { get; set; }

        public AgendaForm()
        {
            InitializeComponent();
            db = new BindingList<AgendaItem>();
            dgwAgenda.DataSource = db;
            btnDeleteRow.Enabled = false;
            btnModifyRow.Enabled = false;
            isDbModified = false;
        }

        public AgendaForm(BindingList<AgendaItem> fakeDb) : this()
        {
            foreach (var contact in fakeDb)
            {
                db.Add(contact);
            }
        }

        private void btnAddNewContact_Click(object sender, EventArgs e)
        {
            this.ValidateChildren(ValidationConstraints.Selectable);
            if (errorProvider.GetError(this.Controls.Find("txtNumeAdd",true).FirstOrDefault()) == "" &&
                errorProvider.GetError(this.Controls.Find("txtPrenumeAdd", true).FirstOrDefault()) == "" &&
                errorProvider.GetError(this.Controls.Find("txtVarstaAdd", true).FirstOrDefault()) == "")
            {
                db.Add(new AgendaItem(txtNumeAdd.Text, txtPrenumeAdd.Text, int.Parse(txtVarstaAdd.Text), txtTelefonAdd.Text, txtEmailAdd.Text));
                isDbModified = true;
                clearFormAdd();
            }
            else {
                MessageBox.Show($"Fill in the form as suggested.");
            }
            
        }

        private void btnClearFormAdd_Click(object sender, EventArgs e)
        {
            clearFormAdd();
        }

        private void clearFormAdd()
        {
            txtNumeAdd.Text = "";
            txtPrenumeAdd.Text = "";
            txtVarstaAdd.Text = "";
            txtTelefonAdd.Text = "";
            txtEmailAdd.Text = "";
            this.ValidateChildren(ValidationConstraints.Selectable);
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
            this.ValidateChildren(ValidationConstraints.Selectable);
            btnModifyRow.Enabled = false;
            btnDeleteRow.Enabled = false;
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
            this.ValidateChildren(ValidationConstraints.Selectable);
            if (errorProvider.GetError(this.Controls.Find("txtNumeMod", true).FirstOrDefault()) == "" &&
                errorProvider.GetError(this.Controls.Find("txtPrenumeMod", true).FirstOrDefault()) == "" &&
                errorProvider.GetError(this.Controls.Find("txtVarstaMod", true).FirstOrDefault()) == "")
            {
                var contactToModify = db.Single(o => o.Id == selectedContact.Id);
                contactToModify.Nume = txtNumeMod.Text;
                contactToModify.Prenume = txtPrenumeMod.Text;
                contactToModify.Varsta = int.Parse(txtVarstaMod.Text);
                contactToModify.Telefon = txtTelefonMod.Text;
                contactToModify.Email = txtEmailMod.Text;
                db.ResetBindings();
                isDbModified = true;
                selectedContact = null;
                txtNumeMod.Text = "";
                txtPrenumeMod.Text = "";
                txtVarstaMod.Text = "";
                txtTelefonMod.Text = "";
                txtEmailMod.Text = "";
                grbModifyContact.Visible = false;
                btnModifyRow.Enabled = true;
                btnDeleteRow.Enabled = true;
            }
            else
            {
                MessageBox.Show($"Fill in the form as suggested.");
            }
            
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
            btnModifyRow.Enabled = true;
            btnDeleteRow.Enabled = true;
            this.ValidateChildren(ValidationConstraints.Selectable);
        }

        private void btnSaveToDb_Click(object sender, EventArgs e)
        {
            SaveToDb();
            isDbModified = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AgendaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isDbModified)
            {
                DialogResult result = MessageBox.Show("Do you want to save your contacts to the database?", "Save changes", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    SaveToDb();
                }
            }
        }

        private void SaveToDb()
        {
            using (StreamWriter file = new StreamWriter($"..\\..\\db\\db.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, db);
            }
        }

        private void txtVarstaAdd_Validating(object sender, CancelEventArgs e)
        {
            ValidateAge("txtVarstaAdd");
        }

        private void txtVarstaMod_Validating(object sender, CancelEventArgs e)
        {
            ValidateAge("txtVarstaMod");
        }

        private bool ValidateAge(string ctrlName)
        {
            bool status = true;
            Control ctrl = this.Controls.Find(ctrlName, true).FirstOrDefault();
            if (ctrl.Text == "")
            {
                errorProvider.SetError(ctrl, "Mandatory field.");
                status = false;
            }
            else
            {
                try
                {
                    int age = int.Parse(ctrl.Text);
                    errorProvider.SetError(ctrl, "");
                    if (age < 18 || age > 120)
                    {
                        errorProvider.SetError(ctrl, "Age must be between 18 and 120.");
                        status = false;
                    }
                }
                catch
                {
                    errorProvider.SetError(ctrl, "Age must be a number.");
                    status = false;
                }
            }
            return status;
        }

        private void txtNumeAdd_Validating(object sender, CancelEventArgs e)
        {
            ValidateNames("txtNumeAdd");
        }

        private void txtNumeMod_Validating(object sender, CancelEventArgs e)
        {
            ValidateNames("txtNumeMod");
        }

        private void txtPrenumeAdd_Validating(object sender, CancelEventArgs e)
        {
            ValidateNames("txtPrenumeAdd");
        }

        private void txtPrenumeMod_Validating(object sender, CancelEventArgs e)
        {
            ValidateNames("txtPrenumeMod");
        }

        public bool ValidateNames(string ctrlName)
        {
            bool status = true;
            Control ctrl = this.Controls.Find(ctrlName, true).FirstOrDefault();

            if (ctrl.Text == "")
            {
                errorProvider.SetError(ctrl, "Mandatory field.");
                status = false;
            }
            else if (ctrl.Text.Length < 3)
            {
                errorProvider.SetError(ctrl, "Length must be atleast 3.");
                status = false;
            }
            else
            {
                errorProvider.SetError(ctrl, "");
            }
            return status;
        }
    }
}
