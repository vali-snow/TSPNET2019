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
    public partial class ComandaAddMod : Form
    {
        private UnitOfWork uow;

        public ComandaAddMod(UnitOfWork uowR)
        {
            InitializeComponent();
            uow = uowR;
        }

        public ComandaAddMod(UnitOfWork uowR, string text) : this(uowR)
        {
            this.Text = text;
            btnAddModComanda.Text = text;
            cmbClientId.Items.AddRange(uow.Clienti.GetAll().Select(c => c.ClientId.ToString()).ToArray());
            cmbAutoId.Items.AddRange(uow.Autoturisme.GetAll().Select(a => a.AutoId.ToString()).ToArray());
        }

        public ComandaAddMod(UnitOfWork uowR, string text, DataGridViewRow comanda) : this(uowR, text)
        {
            txtComandaId.Text = comanda.Cells["Id"].Value.ToString();
            cmbAutoId.SelectedIndex = cmbAutoId.Items.IndexOf(comanda.Cells["AutoId"].Value.ToString());
            cmbClientId.SelectedIndex = cmbClientId.Items.IndexOf(comanda.Cells["ClientId"].Value.ToString());
            cmbStareComanda.SelectedIndex = cmbStareComanda.Items.IndexOf(comanda.Cells["StareComanda"].Value.ToString());
            dtpDataSystem.Value = DateTime.Parse(comanda.Cells["DataSystem"].Value.ToString());
            dtpDataProgramare.Value = DateTime.Parse(comanda.Cells["DataProgramare"].Value.ToString());
            dtpDataFinalizare.Value = DateTime.Parse(comanda.Cells["DataFinalizare"].Value.ToString());
            mtbKmBord.Text = comanda.Cells["KmBord"].Value.ToString();
            txtDescriere.Text = comanda.Cells["Descriere"].Value.ToString();
            txtValoarePiese.Text = comanda.Cells["ValoarePiese"].Value.ToString();

        }

        private void cmbClientId_SelectedIndexChanged(object sender, EventArgs e)
        {
            int autoId;
            var ok = int.TryParse(cmbAutoId.Text, out autoId);
            var clientId = Convert.ToInt32(cmbClientId.Text);
            cmbAutoId.Items.Clear();
            cmbAutoId.Items.AddRange(uow.Autoturisme.GetAll().Where(a => a.ClientId == clientId).Select(a => a.AutoId.ToString()).ToArray());
            if (ok == true) { cmbAutoId.SelectedIndex = cmbAutoId.Items.IndexOf(autoId.ToString()); }


        }

        private void btnAddModComanda_Click(object sender, EventArgs e)
        {
            Enum.TryParse(cmbStareComanda.Text, out Stare stare);
            if (txtComandaId.Text.ToString() == "")
            {
                var comanda = new Comanda() { AutoId = Convert.ToInt32(cmbAutoId.Text), ClientId = Convert.ToInt32(cmbClientId.Text), StareComanda = stare, DataSystem = dtpDataSystem.Value, DataProgramare = dtpDataProgramare.Value, DataFinalizare = dtpDataFinalizare.Value, KmBord = Convert.ToInt32(mtbKmBord.Text), Descriere = txtDescriere.Text, ValoarePiese = 0.00M };
                uow.Comenzi.Add(comanda);
            }
            else
            {
                var comanda = uow.Comenzi.GetById(Convert.ToInt32(txtComandaId.Text.ToString()));
                if (comanda.AutoId != Convert.ToInt32(cmbAutoId.Text)) { comanda.AutoId = Convert.ToInt32(cmbAutoId.Text); }
                if (comanda.ClientId != Convert.ToInt32(cmbClientId.Text)) { comanda.ClientId = Convert.ToInt32(cmbClientId.Text); }
                if (comanda.StareComanda != stare) { comanda.StareComanda = stare; }
                if (comanda.DataSystem != dtpDataSystem.Value) { comanda.DataSystem = dtpDataSystem.Value; }
                if (comanda.DataProgramare != dtpDataProgramare.Value) { comanda.DataProgramare = dtpDataProgramare.Value; }
                if (comanda.DataFinalizare != dtpDataFinalizare.Value) { comanda.DataFinalizare = dtpDataFinalizare.Value; }
                if (comanda.KmBord != Convert.ToInt32(mtbKmBord.Text)) { comanda.KmBord = Convert.ToInt32(mtbKmBord.Text); }
                if (comanda.Descriere != txtDescriere.Text) { comanda.Descriere = txtDescriere.Text; }
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
