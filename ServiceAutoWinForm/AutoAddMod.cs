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
    public partial class AutoAddMod : Form
    {
        private UnitOfWork uow;
        public AutoAddMod(UnitOfWork uowR)
        {
            InitializeComponent();
            uow = uowR;
        }
        public AutoAddMod(UnitOfWork uowR, string text): this(uowR)
        {
            this.Text = text;
            btnAddModAuto.Text = text;
            cmbClientId.Items.AddRange(uow.Clienti.GetAll().Select(c => c.ClientId.ToString()).ToArray());
            cmbSasiuId.Items.AddRange(uow.Sasiuri.GetAll().Select(s => s.SasiuId.ToString()).ToArray());
        }
        public AutoAddMod(UnitOfWork uowR, string text, DataGridViewRow auto) : this(uowR, text)
        {
            txtAutoId.Text = auto.Cells["Id"].Value.ToString();
            txtNumarAuto.Text = auto.Cells["NumarAuto"].Value.ToString();
            cmbSasiuId.SelectedIndex = cmbSasiuId.Items.IndexOf(auto.Cells["SasiuId"].Value.ToString());
            txtSerieSasiu.Text = auto.Cells["SerieSasiu"].Value.ToString();
            cmbClientId.SelectedIndex = cmbClientId.Items.IndexOf(auto.Cells["ClientId"].Value.ToString());
        }

        private void btnAddModAuto_Click(object sender, EventArgs e)
        {
            if (txtAutoId.Text.ToString() == "")
            {
                var auto = new Auto() { NumarAuto = txtNumarAuto.Text, SasiuId = Convert.ToInt32(cmbSasiuId.Text), SerieSasiu = txtSerieSasiu.Text, ClientId = Convert.ToInt32(cmbClientId.Text) };
                uow.Autoturisme.Add(auto);
            }
            else
            {
                var auto = uow.Autoturisme.GetById(Convert.ToInt32(txtAutoId.Text.ToString()));
                if (auto.NumarAuto != txtNumarAuto.Text) { auto.NumarAuto = txtNumarAuto.Text; }
                if (auto.SasiuId != Convert.ToInt32(cmbSasiuId.Text)) { auto.SasiuId = Convert.ToInt32(cmbSasiuId.Text); }
                if (auto.SerieSasiu != txtSerieSasiu.Text) { auto.SerieSasiu = txtSerieSasiu.Text; }
                if (auto.ClientId != Convert.ToInt32(cmbClientId.Text)) { auto.ClientId = Convert.ToInt32(cmbClientId.Text); }
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
