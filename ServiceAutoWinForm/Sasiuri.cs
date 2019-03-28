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
    public partial class Sasiuri : Form
    {
        private UnitOfWork uow;
        internal Dictionary<string, string> onCloseParameters = new Dictionary<string, string>();
        public Sasiuri(UnitOfWork uowR)
        {
            InitializeComponent();
            uow = uowR;
        }

        private void RefreshGrid()
        {
            var bind = new BindingSource();
            bind.DataSource = uow.Sasiuri.GetAll();
            dataGridViewSasiuri.DataSource = bind;
            dataGridViewSasiuri.ClearSelection();
            btnLinkAutoturisme.Enabled = false;
            btnModifySelectedSasiu.Enabled = false;
            btnRemoveSelectedSasiuri.Enabled = false;
            btnRefreshSasiuri.Enabled = true;
            btnAddSasiu.Enabled = true;
            btnExitSasiuri.Enabled = true;
            dataGridViewSasiuri.Refresh();
        }

        private void Sasiuri_Load(object sender, EventArgs e)
        {
            dataGridViewSasiuri.AutoGenerateColumns = false;
            dataGridViewSasiuri.Columns.AddRange(new[] {
                new  DataGridViewTextBoxColumn() { Name = "Id", DataPropertyName = "SasiuId"},
                new  DataGridViewTextBoxColumn() { Name = "CodSasiu", DataPropertyName = "CodSasiu"},
                new  DataGridViewTextBoxColumn() { Name = "Denumire", DataPropertyName = "Denumire"},
            });
            RefreshGrid();
        }

        private void dataGridViewSasiuri_SelectionChanged(object sender, EventArgs e)
        {
            switch (dataGridViewSasiuri.SelectedRows.Count)
            {
                case 0:
                    btnLinkAutoturisme.Enabled = false;
                    btnModifySelectedSasiu.Enabled = false;
                    btnRemoveSelectedSasiuri.Enabled = false;
                    btnRefreshSasiuri.Enabled = true;
                    btnAddSasiu.Enabled = true;
                    btnExitSasiuri.Enabled = true;
                    break;
                case 1:
                    btnLinkAutoturisme.Enabled = true;
                    btnModifySelectedSasiu.Enabled = true;
                    btnRemoveSelectedSasiuri.Enabled = true;
                    btnRefreshSasiuri.Enabled = true;
                    btnAddSasiu.Enabled = true;
                    btnExitSasiuri.Enabled = true;
                    break;
                default:
                    btnLinkAutoturisme.Enabled = false;
                    btnModifySelectedSasiu.Enabled = false;
                    btnRemoveSelectedSasiuri.Enabled = true;
                    btnRefreshSasiuri.Enabled = true;
                    btnAddSasiu.Enabled = true;
                    btnExitSasiuri.Enabled = true;
                    break;
            }
        }

        private void btnLinkAutoturisme_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            onCloseParameters.Add("toOpen", "Autoturisme");
            onCloseParameters.Add("sasiuId", dataGridViewSasiuri.SelectedRows[0].Cells["Id"].Value.ToString());
            this.Close();
        }

        private void btnModifySelectedSasiu_Click(object sender, EventArgs e)
        {
            using (var form = new SasiuAddMod(uow, "Modify Sasiu", dataGridViewSasiuri.SelectedRows[0]))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    RefreshGrid();
                }
            }
        }

        private void btnRemoveSelectedSasiuri_Click(object sender, EventArgs e)
        {
            var sasiuriToDelete = new List<Sasiu>();
            foreach (DataGridViewRow selectedRow in dataGridViewSasiuri.SelectedRows)
            {
                sasiuriToDelete.Add(uow.Sasiuri.GetById(Convert.ToInt32(selectedRow.Cells["Id"].Value)));
            }
            uow.Sasiuri.RemoveRange(sasiuriToDelete);
            uow.Complete();
            RefreshGrid();
        }

        private void btnRefreshSasiuri_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void btnAddSasiu_Click(object sender, EventArgs e)
        {
            using (var form = new SasiuAddMod(uow, "Add Sasiu"))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    RefreshGrid();
                }
            }
        }

        private void btnExitSasiuri_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
