﻿using ServiceAutoClassLibrary;
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
    public partial class Clienti : Form
    {
        private UnitOfWork uow;
        private BindingList<Client> clienti;
        public Clienti(UnitOfWork uowR)
        {
            InitializeComponent();
            uow = uowR;

        }

        private void RefreshGrid()
        {
            var bind = new BindingSource();
            bind.DataSource = uow.Clienti.GetAll();
            dataGridViewClienti.DataSource = bind;
            dataGridViewClienti.ClearSelection();
            btnRefreshClient.Enabled = true;
            btnAddClient.Enabled = true;
            btnModifySelectedClient.Enabled = false;
            btnRemoveSelectedClienti.Enabled = false;
            btnExitClienti.Enabled = true;
            dataGridViewClienti.Refresh();
        }

        private void Clienti_Load(object sender, EventArgs e)
        {
            dataGridViewClienti.AutoGenerateColumns = false;
            dataGridViewClienti.Columns.AddRange(new[] {
                new  DataGridViewTextBoxColumn() { Name = "Id", DataPropertyName = "ClientId"},
                new  DataGridViewTextBoxColumn() { Name = "Nume", DataPropertyName = "Nume"},
                new  DataGridViewTextBoxColumn() { Name = "Prenume", DataPropertyName = "Prenume"},
                new  DataGridViewTextBoxColumn() { Name = "Adresa", DataPropertyName = "Adresa"},
                new  DataGridViewTextBoxColumn() { Name = "Localitate", DataPropertyName = "Localitate"},
                new  DataGridViewTextBoxColumn() { Name = "Judet", DataPropertyName = "Judet"},
                new  DataGridViewTextBoxColumn() { Name = "Telefon", DataPropertyName = "Telefon"},
                new  DataGridViewTextBoxColumn() { Name = "Email", DataPropertyName = "Email"}
            });
            RefreshGrid();
        }

        private void dataGridViewClienti_SelectionChanged(object sender, EventArgs e)
        {
            switch (dataGridViewClienti.SelectedRows.Count)
            {
                case 0:
                    btnRefreshClient.Enabled = true;
                    btnAddClient.Enabled = true;
                    btnModifySelectedClient.Enabled = false;
                    btnRemoveSelectedClienti.Enabled = false;
                    btnExitClienti.Enabled = true;
                    break;
                case 1:
                    btnRefreshClient.Enabled = true;
                    btnAddClient.Enabled = true;
                    btnModifySelectedClient.Enabled = true;
                    btnRemoveSelectedClienti.Enabled = true;
                    btnExitClienti.Enabled = true;
                    break;
                default:
                    btnRefreshClient.Enabled = true;
                    btnAddClient.Enabled = true;
                    btnModifySelectedClient.Enabled = false;
                    btnRemoveSelectedClienti.Enabled = true;
                    btnExitClienti.Enabled = true;
                    break;
            }
        }

        private void btnRefreshClient_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            using (var form = new ClientiAddMod(uow, "Add Client"))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    RefreshGrid();
                }
            }
            
        }

        private void btnModifySelectedClient_Click(object sender, EventArgs e)
        {
            using (var form = new ClientiAddMod(uow, "Modify Client", dataGridViewClienti.SelectedRows[0]))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    RefreshGrid();
                }
            }
        }

        private void btnRemoveSelectedClienti_Click(object sender, EventArgs e)
        {
            var clientsToDelete = new List<Client>();
            foreach (DataGridViewRow selectedRow in dataGridViewClienti.SelectedRows)
            {
                clientsToDelete.Add(uow.Clienti.GetById(Convert.ToInt32(selectedRow.Cells["Id"].Value)));
            }
            uow.Clienti.RemoveRange(clientsToDelete);
            uow.Complete();
            RefreshGrid();
        }

        private void btnExitClienti_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
