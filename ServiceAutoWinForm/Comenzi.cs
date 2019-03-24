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
    public partial class Comenzi : Form
    {
        private UnitOfWork uow;
        internal Dictionary<string, string> onCloseParameters = new Dictionary<string, string>();

        public Comenzi(UnitOfWork uowR)
        {
            InitializeComponent();
            uow = uowR;
            cmbClientId.Items.AddRange(uow.Clienti.GetAll().Select(c => c.ClientId.ToString()).ToArray());
            cmbAutoId.Items.AddRange(uow.Autoturisme.GetAll().Select(a => a.AutoId.ToString()).ToArray());
        }

        public Comenzi(UnitOfWork uowR, Dictionary<string, string> parameters) : this(uowR)
        {
            if (parameters.ContainsKey("clientId"))
            {
                cmbClientId.SelectedIndex = cmbClientId.Items.IndexOf(parameters["clientId"]);
            }
            if (parameters.ContainsKey("autoId"))
            {
                cmbAutoId.SelectedIndex = cmbAutoId.Items.IndexOf(parameters["autoId"]);
            }
        }

        private void RefreshGrid()
        {
            var bind = new BindingSource();
            if (cmbClientId.Text != "" && cmbAutoId.Text != "")
            {
                var clientId = Convert.ToInt32(cmbClientId.Text);
                var autoId = Convert.ToInt32(cmbAutoId.Text);
                bind.DataSource = uow.Comenzi.GetFiltered(c => c.ClientId == clientId && c.AutoId == autoId).ToList();
            }
            else if (cmbClientId.Text != "")
            {
                var clientId = Convert.ToInt32(cmbClientId.Text);
                bind.DataSource = uow.Comenzi.GetFiltered(c => c.ClientId == clientId).ToList();
            }
            else if (cmbAutoId.Text != "")
            {
                var autoId = Convert.ToInt32(cmbAutoId.Text);
                bind.DataSource = uow.Comenzi.GetFiltered(c => c.AutoId == autoId).ToList();
            }
            else
            {
                bind.DataSource = uow.Comenzi.GetAll();
            }

            dataGridViewComenzi.DataSource = bind;
            dataGridViewComenzi.ClearSelection();
            btnLinkDetaliiComanda.Enabled = false;
            btnModifySelectedComanda.Enabled = false;
            btnRemoveSelectedComenzi.Enabled = false;
            btnRefreshComanda.Enabled = true;
            btnAddComanda.Enabled = true;
            btnExitComenzi.Enabled = true;
            dataGridViewComenzi.Refresh();
        }

        private void Comenzi_Load(object sender, EventArgs e)
        {
            dataGridViewComenzi.AutoGenerateColumns = false;
            dataGridViewComenzi.Columns.AddRange(new[] {
                new  DataGridViewTextBoxColumn() { Name = "Id", DataPropertyName = "ComandaId"},
                new  DataGridViewTextBoxColumn() { Name = "AutoId", DataPropertyName = "AutoId"},
                new  DataGridViewTextBoxColumn() { Name = "ClientId", DataPropertyName = "ClientId"},
                new  DataGridViewTextBoxColumn() { Name = "StareComanda", DataPropertyName = "StareComanda"},
                new  DataGridViewTextBoxColumn() { Name = "DataSystem", DataPropertyName = "DataSystem"},
                new  DataGridViewTextBoxColumn() { Name = "DataProgramare", DataPropertyName = "DataProgramare"},
                new  DataGridViewTextBoxColumn() { Name = "DataFinalizare", DataPropertyName = "DataFinalizare"},
                new  DataGridViewTextBoxColumn() { Name = "KmBord", DataPropertyName = "KmBord"},
                new  DataGridViewTextBoxColumn() { Name = "Descriere", DataPropertyName = "Descriere"},
                new  DataGridViewTextBoxColumn() { Name = "ValoarePiese", DataPropertyName = "ValoarePiese"}
            });
            RefreshGrid();
        }

        private void dataGridViewComenzi_SelectionChanged(object sender, EventArgs e)
        {
            switch (dataGridViewComenzi.SelectedRows.Count)
            {
                case 0:
                    btnLinkDetaliiComanda.Enabled = false;
                    btnModifySelectedComanda.Enabled = false;
                    btnRemoveSelectedComenzi.Enabled = false;
                    btnRefreshComanda.Enabled = true;
                    btnAddComanda.Enabled = true;
                    btnExitComenzi.Enabled = true;
                    break;
                case 1:
                    btnLinkDetaliiComanda.Enabled = true;
                    btnModifySelectedComanda.Enabled = true;
                    btnRemoveSelectedComenzi.Enabled = true;
                    btnRefreshComanda.Enabled = true;
                    btnAddComanda.Enabled = true;
                    btnExitComenzi.Enabled = true;
                    break;
                default:
                    btnLinkDetaliiComanda.Enabled = false;
                    btnModifySelectedComanda.Enabled = false;
                    btnRemoveSelectedComenzi.Enabled = true;
                    btnRefreshComanda.Enabled = true;
                    btnAddComanda.Enabled = true;
                    btnExitComenzi.Enabled = true;
                    break;
            }
        }

        private void cmbClientId_SelectionChangeCommitted(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void cmbAutoId_SelectionChangeCommitted(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void btnClearFilters_Click(object sender, EventArgs e)
        {
            cmbClientId.SelectedIndex = -1;
            cmbAutoId.SelectedIndex = -1;
            RefreshGrid();
        }

        private void btnLinkDetaliiComanda_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            onCloseParameters.Add("toOpen", "DetaliiComenzi");
            onCloseParameters.Add("comandaId", dataGridViewComenzi.SelectedRows[0].Cells["Id"].Value.ToString());
            this.Close();
        }

        private void btnModifySelectedComanda_Click(object sender, EventArgs e)
        {
            using (var form = new ComandaAddMod(uow, "Modify Comanda", dataGridViewComenzi.SelectedRows[0]))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    RefreshGrid();
                }
            }
        }

        private void btnRemoveSelectedComenzi_Click(object sender, EventArgs e)
        {
            var comenziToDelete = new List<Comanda>();
            foreach (DataGridViewRow selectedRow in dataGridViewComenzi.SelectedRows)
            {
                comenziToDelete.Add(uow.Comenzi.GetById(Convert.ToInt32(selectedRow.Cells["Id"].Value)));
            }
            uow.Comenzi.RemoveRange(comenziToDelete);
            uow.Complete();
            RefreshGrid();
        }

        private void btnRefreshComanda_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void btnAddComanda_Click(object sender, EventArgs e)
        {
            using (var form = new ComandaAddMod(uow, "Add Comanda"))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    RefreshGrid();
                }
            }
        }

        private void btnExitComenzi_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
