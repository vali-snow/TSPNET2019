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
    public partial class ClientiAddMod : Form
    {
        private UnitOfWork uow;

        public ClientiAddMod(UnitOfWork uowR)
        {
            InitializeComponent();
            uow = uowR;
        }
        public ClientiAddMod(UnitOfWork uowR, string text) : this(uowR)
        {
            this.Text = text;
            btnAddModClient.Text = text;
            cmbJudet.Items.AddRange(new[] { "Alba", "Arad", "Arges", "Bacau", "Bihor", "Bistrita Nasaud", "Botosani", "Braila", "Brasov", "Bucuresti", "Buzau", "Calarasi", "Caras Severin", "Cluj", "Constanta", "Covasna", "Dambovita", "Dolj", "Galati", "Giurgiu", "Gorj", "Harghita", "Hunedoara", "Ialomita", "Iasi", "Ilfov", "Maramures", "Mehedinti", "Mures", "Neamt", "Olt", "Prahova", "Salaj", "Satu Mare", "Sibiu", "Suceava", "Teleorman", "Timis", "Tulcea", "Valcea", "Vaslui", "Vrancea" });
        }
        public ClientiAddMod(UnitOfWork uowR, string text, DataGridViewRow client) : this(uowR, text)
        {
            txtClientId.Text = client.Cells["Id"].Value.ToString();
            txtNume.Text = client.Cells["Nume"].Value.ToString();
            txtPrenume.Text = client.Cells["Prenume"].Value.ToString();
            txtAdresa.Text = client.Cells["Adresa"].Value.ToString();
            txtLocalitate.Text = client.Cells["Localitate"].Value.ToString();
            cmbJudet.SelectedIndex = cmbJudet.Items.IndexOf(client.Cells["Judet"].Value.ToString());
            txtTelefon.Text = client.Cells["Telefon"].Value.ToString();
            txtEmail.Text = client.Cells["Email"].Value.ToString();
        }

        private void ClientiAddMod_Load(object sender, EventArgs e)
        {
        }

        private void btnAddModClient_Click(object sender, EventArgs e)
        {
            if (txtClientId.Text.ToString() == "")
            {
                var client = new Client() { Nume = txtNume.Text, Prenume = txtPrenume.Text, Adresa = txtAdresa.Text, Localitate = txtLocalitate.Text, Judet = cmbJudet.Text, Telefon = txtTelefon.Text, Email = txtEmail.Text };
                uow.Clienti.Add(client);
            }
            else
            {
                var client = uow.Clienti.GetById(Convert.ToInt32(txtClientId.Text.ToString()));
                client.Nume = txtNume.Text;
                if (client.Nume != txtNume.Text) { client.Nume = txtNume.Text; }
                if (client.Prenume != txtPrenume.Text) { client.Prenume = txtPrenume.Text; }
                if (client.Adresa != txtAdresa.Text) { client.Adresa = txtAdresa.Text; }
                if (client.Localitate != txtLocalitate.Text) { client.Localitate = txtLocalitate.Text; }
                if (client.Judet != cmbJudet.Text) { client.Judet = cmbJudet.Text; }
                if (client.Telefon != txtTelefon.Text) { client.Telefon = txtTelefon.Text; }
                if (client.Email != txtEmail.Text) { client.Email = txtEmail.Text; }
            }
            uow.Complete();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
