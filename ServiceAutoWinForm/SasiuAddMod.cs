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
    public partial class SasiuAddMod : Form
    {
        private UnitOfWork uow;
        public SasiuAddMod(UnitOfWork uowR)
        {
            InitializeComponent();
            uow = uowR;
        }
        public SasiuAddMod(UnitOfWork uowR, string text) : this(uowR)
        {
            this.Text = text;
            btnAddModSasiu.Text = text;
        }
        public SasiuAddMod(UnitOfWork uowR, string text, DataGridViewRow auto) : this(uowR, text)
        {
            txtSasiuId.Text = auto.Cells["Id"].Value.ToString();
            txtCodSasiu.Text = auto.Cells["CodSasiu"].Value.ToString();
            txtDenumire.Text = auto.Cells["Denumire"].Value.ToString();
        }

        private void btnAddModSasiu_Click(object sender, EventArgs e)
        {
            if (txtSasiuId.Text.ToString() == "")
            {
                var sasiu = new Sasiu() { CodSasiu = txtCodSasiu.Text, Denumire = txtDenumire.Text, };
                uow.Sasiuri.Add(sasiu);
            }
            else
            {
                var sasiu = uow.Sasiuri.GetById(Convert.ToInt32(txtSasiuId.Text.ToString()));
                if (sasiu.CodSasiu != txtCodSasiu.Text) { sasiu.CodSasiu = txtCodSasiu.Text; }
                if (sasiu.Denumire != txtDenumire.Text) { sasiu.Denumire = txtDenumire.Text; }
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
