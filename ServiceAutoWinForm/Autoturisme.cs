using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServiceAutoClassLibrary;
using ServiceAutoClassLibrary.Repositories;

namespace ServiceAutoWinForm
{
    public partial class Autoturisme : Form
    {
        private UnitOfWork uow;
        internal Dictionary<string, string> onCloseParameters = new Dictionary<string, string>();

        public Autoturisme(UnitOfWork uowR)
        {
            InitializeComponent();
            uow = uowR;
            cmbClientId.Items.AddRange(uow.Clienti.GetAll().Select(c => c.ClientId.ToString()).ToArray());
            cmbSasiuId.Items.AddRange(uow.Sasiuri.GetAll().Select(s => s.SasiuId.ToString()).ToArray());
        }

        public Autoturisme(UnitOfWork uowR, Dictionary<string, string> parameters) : this(uowR)
        {
            if (parameters.ContainsKey("clientId"))
            {
                cmbClientId.SelectedIndex = cmbClientId.Items.IndexOf(parameters["clientId"]);
            }
            if (parameters.ContainsKey("sasiuId"))
            {
                cmbSasiuId.SelectedIndex = cmbSasiuId.Items.IndexOf(parameters["sasiuId"]);
            }
        }

        private void RefreshGrid()
        {
            var bind = new BindingSource();
            if (cmbClientId.Text != "" && cmbSasiuId.Text != "")
            {
                var clientId = Convert.ToInt32(cmbClientId.Text);
                var sasiuId = Convert.ToInt32(cmbSasiuId.Text);
                bind.DataSource = uow.Autoturisme.GetFiltered(a => a.ClientId == clientId && a.SasiuId == sasiuId).ToList();
            }
            else if (cmbClientId.Text != "")
            {
                var clientId = Convert.ToInt32(cmbClientId.Text);
                bind.DataSource = uow.Autoturisme.GetFiltered(a => a.ClientId == clientId).ToList();
            }
            else if (cmbSasiuId.Text != "")
            {
                var sasiuId = Convert.ToInt32(cmbSasiuId.Text);
                bind.DataSource = uow.Autoturisme.GetFiltered(a => a.SasiuId == sasiuId).ToList();
            }
            else
            {
                bind.DataSource = uow.Autoturisme.GetAll();
            }
            
            dataGridViewAutoturisme.DataSource = bind;
            dataGridViewAutoturisme.ClearSelection();
            btnLinkComenzi.Enabled = false;
            btnModifySelectedAutoturism.Enabled = false;
            btnRemoveSelectedAutoturisme.Enabled = false;
            btnRefreshAutoturisme.Enabled = true;
            btnAddAutoturism.Enabled = true;
            btnExitAutoturisme.Enabled = true;
            dataGridViewAutoturisme.Refresh();
        }

        private void Autoturisme_Load(object sender, EventArgs e)
        {
            dataGridViewAutoturisme.AutoGenerateColumns = false;
            dataGridViewAutoturisme.Columns.AddRange(new[] {
                new  DataGridViewTextBoxColumn() { Name = "Id", DataPropertyName = "AutoId"},
                new  DataGridViewTextBoxColumn() { Name = "NumarAuto", DataPropertyName = "NumarAuto"},
                new  DataGridViewTextBoxColumn() { Name = "SasiuId", DataPropertyName = "SasiuId"},
                new  DataGridViewTextBoxColumn() { Name = "SerieSasiu", DataPropertyName = "SerieSasiu"},
                new  DataGridViewTextBoxColumn() { Name = "ClientId", DataPropertyName = "ClientId"}
            });
            RefreshGrid();
        }

        private void dataGridViewAutoturisme_SelectionChanged(object sender, EventArgs e)
        {
            switch (dataGridViewAutoturisme.SelectedRows.Count)
            {
                case 0:
                    btnLinkComenzi.Enabled = false;
                    btnModifySelectedAutoturism.Enabled = false;
                    btnRemoveSelectedAutoturisme.Enabled = false;
                    btnRefreshAutoturisme.Enabled = true;
                    btnAddAutoturism.Enabled = true;
                    btnExitAutoturisme.Enabled = true;
                    break;
                case 1:
                    btnLinkComenzi.Enabled = true;
                    btnModifySelectedAutoturism.Enabled = true;
                    btnRemoveSelectedAutoturisme.Enabled = true;
                    btnRefreshAutoturisme.Enabled = true;
                    btnAddAutoturism.Enabled = true;
                    btnExitAutoturisme.Enabled = true;
                    break;
                default:
                    btnLinkComenzi.Enabled = false;
                    btnModifySelectedAutoturism.Enabled = false;
                    btnRemoveSelectedAutoturisme.Enabled = true;
                    btnRefreshAutoturisme.Enabled = true;
                    btnAddAutoturism.Enabled = true;
                    btnExitAutoturisme.Enabled = true;
                    break;
            }
        }

        private void cmbClientId_SelectionChangeCommitted(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void cmbSasiuId_SelectionChangeCommitted(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void btnClearFilters_Click(object sender, EventArgs e)
        {
            cmbClientId.SelectedIndex = -1;
            cmbSasiuId.SelectedIndex = -1;
            RefreshGrid();
        }

        private void btnLinkComenzi_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            onCloseParameters.Add("toOpen", "Comenzi");
            onCloseParameters.Add("autoId", dataGridViewAutoturisme.SelectedRows[0].Cells["Id"].Value.ToString());
            this.Close();
        }

        private void btnModifySelectedAutoturism_Click(object sender, EventArgs e)
        {
            using (var form = new AutoAddMod(uow, "Modify Auto", dataGridViewAutoturisme.SelectedRows[0]))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    RefreshGrid();
                }
            }
        }

        private void btnRemoveSelectedAutoturisme_Click(object sender, EventArgs e)
        {
            var autosToDelete = new List<Auto>();
            foreach (DataGridViewRow selectedRow in dataGridViewAutoturisme.SelectedRows)
            {
                autosToDelete.Add(uow.Autoturisme.GetById(Convert.ToInt32(selectedRow.Cells["Id"].Value)));
            }
            uow.Autoturisme.RemoveRange(autosToDelete);
            uow.Complete();
            RefreshGrid();
        }

        private void btnRefreshAutoturisme_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void btnAddAutoturism_Click(object sender, EventArgs e)
        {
            using (var form = new AutoAddMod(uow, "Add Auto"))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    RefreshGrid();
                }
            }
        }

        private void btnExitAutoturisme_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
