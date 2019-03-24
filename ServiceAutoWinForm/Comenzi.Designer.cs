namespace ServiceAutoWinForm
{
    partial class Comenzi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLinkDetaliiComanda = new System.Windows.Forms.Button();
            this.btnClearFilters = new System.Windows.Forms.Button();
            this.btnRefreshComanda = new System.Windows.Forms.Button();
            this.btnExitComenzi = new System.Windows.Forms.Button();
            this.btnRemoveSelectedComenzi = new System.Windows.Forms.Button();
            this.btnModifySelectedComanda = new System.Windows.Forms.Button();
            this.btnAddComanda = new System.Windows.Forms.Button();
            this.dataGridViewComenzi = new System.Windows.Forms.DataGridView();
            this.cmbAutoId = new System.Windows.Forms.ComboBox();
            this.lblFilterAutoId = new System.Windows.Forms.Label();
            this.cmbClientId = new System.Windows.Forms.ComboBox();
            this.lblFilterClientId = new System.Windows.Forms.Label();
            this.lblComenzi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComenzi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLinkDetaliiComanda
            // 
            this.btnLinkDetaliiComanda.Location = new System.Drawing.Point(12, 488);
            this.btnLinkDetaliiComanda.Name = "btnLinkDetaliiComanda";
            this.btnLinkDetaliiComanda.Size = new System.Drawing.Size(155, 23);
            this.btnLinkDetaliiComanda.TabIndex = 46;
            this.btnLinkDetaliiComanda.Text = "Link Detalii Comanda";
            this.btnLinkDetaliiComanda.UseVisualStyleBackColor = true;
            this.btnLinkDetaliiComanda.Click += new System.EventHandler(this.btnLinkDetaliiComanda_Click);
            // 
            // btnClearFilters
            // 
            this.btnClearFilters.Location = new System.Drawing.Point(534, 38);
            this.btnClearFilters.Name = "btnClearFilters";
            this.btnClearFilters.Size = new System.Drawing.Size(155, 23);
            this.btnClearFilters.TabIndex = 45;
            this.btnClearFilters.Text = "Clear Filters";
            this.btnClearFilters.UseVisualStyleBackColor = true;
            this.btnClearFilters.Click += new System.EventHandler(this.btnClearFilters_Click);
            // 
            // btnRefreshComanda
            // 
            this.btnRefreshComanda.Location = new System.Drawing.Point(12, 517);
            this.btnRefreshComanda.Name = "btnRefreshComanda";
            this.btnRefreshComanda.Size = new System.Drawing.Size(155, 23);
            this.btnRefreshComanda.TabIndex = 44;
            this.btnRefreshComanda.Text = "Refresh";
            this.btnRefreshComanda.UseVisualStyleBackColor = true;
            this.btnRefreshComanda.Click += new System.EventHandler(this.btnRefreshComanda_Click);
            // 
            // btnExitComenzi
            // 
            this.btnExitComenzi.Location = new System.Drawing.Point(708, 517);
            this.btnExitComenzi.Name = "btnExitComenzi";
            this.btnExitComenzi.Size = new System.Drawing.Size(155, 23);
            this.btnExitComenzi.TabIndex = 43;
            this.btnExitComenzi.Text = "Exit";
            this.btnExitComenzi.UseVisualStyleBackColor = true;
            this.btnExitComenzi.Click += new System.EventHandler(this.btnExitComenzi_Click);
            // 
            // btnRemoveSelectedComenzi
            // 
            this.btnRemoveSelectedComenzi.Location = new System.Drawing.Point(708, 488);
            this.btnRemoveSelectedComenzi.Name = "btnRemoveSelectedComenzi";
            this.btnRemoveSelectedComenzi.Size = new System.Drawing.Size(155, 23);
            this.btnRemoveSelectedComenzi.TabIndex = 42;
            this.btnRemoveSelectedComenzi.Text = "Remove Selected";
            this.btnRemoveSelectedComenzi.UseVisualStyleBackColor = true;
            this.btnRemoveSelectedComenzi.Click += new System.EventHandler(this.btnRemoveSelectedComenzi_Click);
            // 
            // btnModifySelectedComanda
            // 
            this.btnModifySelectedComanda.Location = new System.Drawing.Point(360, 488);
            this.btnModifySelectedComanda.Name = "btnModifySelectedComanda";
            this.btnModifySelectedComanda.Size = new System.Drawing.Size(155, 23);
            this.btnModifySelectedComanda.TabIndex = 41;
            this.btnModifySelectedComanda.Text = "Modify Selected";
            this.btnModifySelectedComanda.UseVisualStyleBackColor = true;
            this.btnModifySelectedComanda.Click += new System.EventHandler(this.btnModifySelectedComanda_Click);
            // 
            // btnAddComanda
            // 
            this.btnAddComanda.Location = new System.Drawing.Point(360, 517);
            this.btnAddComanda.Name = "btnAddComanda";
            this.btnAddComanda.Size = new System.Drawing.Size(155, 23);
            this.btnAddComanda.TabIndex = 40;
            this.btnAddComanda.Text = "Add New";
            this.btnAddComanda.UseVisualStyleBackColor = true;
            this.btnAddComanda.Click += new System.EventHandler(this.btnAddComanda_Click);
            // 
            // dataGridViewComenzi
            // 
            this.dataGridViewComenzi.AllowUserToAddRows = false;
            this.dataGridViewComenzi.AllowUserToDeleteRows = false;
            this.dataGridViewComenzi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewComenzi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewComenzi.Location = new System.Drawing.Point(12, 67);
            this.dataGridViewComenzi.Name = "dataGridViewComenzi";
            this.dataGridViewComenzi.ReadOnly = true;
            this.dataGridViewComenzi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewComenzi.Size = new System.Drawing.Size(852, 415);
            this.dataGridViewComenzi.TabIndex = 39;
            this.dataGridViewComenzi.SelectionChanged += new System.EventHandler(this.dataGridViewComenzi_SelectionChanged);
            // 
            // cmbAutoId
            // 
            this.cmbAutoId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAutoId.FormattingEnabled = true;
            this.cmbAutoId.Location = new System.Drawing.Point(310, 40);
            this.cmbAutoId.Name = "cmbAutoId";
            this.cmbAutoId.Size = new System.Drawing.Size(156, 21);
            this.cmbAutoId.TabIndex = 38;
            this.cmbAutoId.SelectionChangeCommitted += new System.EventHandler(this.cmbAutoId_SelectionChangeCommitted);
            // 
            // lblFilterAutoId
            // 
            this.lblFilterAutoId.AutoSize = true;
            this.lblFilterAutoId.Location = new System.Drawing.Point(259, 43);
            this.lblFilterAutoId.Name = "lblFilterAutoId";
            this.lblFilterAutoId.Size = new System.Drawing.Size(41, 13);
            this.lblFilterAutoId.TabIndex = 37;
            this.lblFilterAutoId.Text = "AutoId:";
            // 
            // cmbClientId
            // 
            this.cmbClientId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClientId.FormattingEnabled = true;
            this.cmbClientId.Location = new System.Drawing.Point(63, 40);
            this.cmbClientId.Name = "cmbClientId";
            this.cmbClientId.Size = new System.Drawing.Size(156, 21);
            this.cmbClientId.TabIndex = 36;
            this.cmbClientId.SelectionChangeCommitted += new System.EventHandler(this.cmbClientId_SelectionChangeCommitted);
            // 
            // lblFilterClientId
            // 
            this.lblFilterClientId.AutoSize = true;
            this.lblFilterClientId.Location = new System.Drawing.Point(12, 43);
            this.lblFilterClientId.Name = "lblFilterClientId";
            this.lblFilterClientId.Size = new System.Drawing.Size(45, 13);
            this.lblFilterClientId.TabIndex = 35;
            this.lblFilterClientId.Text = "ClientId:";
            // 
            // lblComenzi
            // 
            this.lblComenzi.AutoSize = true;
            this.lblComenzi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComenzi.Location = new System.Drawing.Point(445, 11);
            this.lblComenzi.Name = "lblComenzi";
            this.lblComenzi.Size = new System.Drawing.Size(85, 24);
            this.lblComenzi.TabIndex = 34;
            this.lblComenzi.Text = "Comenzi";
            // 
            // Comenzi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 548);
            this.Controls.Add(this.btnLinkDetaliiComanda);
            this.Controls.Add(this.btnClearFilters);
            this.Controls.Add(this.btnRefreshComanda);
            this.Controls.Add(this.btnExitComenzi);
            this.Controls.Add(this.btnRemoveSelectedComenzi);
            this.Controls.Add(this.btnModifySelectedComanda);
            this.Controls.Add(this.btnAddComanda);
            this.Controls.Add(this.dataGridViewComenzi);
            this.Controls.Add(this.cmbAutoId);
            this.Controls.Add(this.lblFilterAutoId);
            this.Controls.Add(this.cmbClientId);
            this.Controls.Add(this.lblFilterClientId);
            this.Controls.Add(this.lblComenzi);
            this.Name = "Comenzi";
            this.Text = "Comenzi";
            this.Load += new System.EventHandler(this.Comenzi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComenzi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLinkDetaliiComanda;
        private System.Windows.Forms.Button btnClearFilters;
        private System.Windows.Forms.Button btnRefreshComanda;
        private System.Windows.Forms.Button btnExitComenzi;
        private System.Windows.Forms.Button btnRemoveSelectedComenzi;
        private System.Windows.Forms.Button btnModifySelectedComanda;
        private System.Windows.Forms.Button btnAddComanda;
        private System.Windows.Forms.DataGridView dataGridViewComenzi;
        private System.Windows.Forms.ComboBox cmbAutoId;
        private System.Windows.Forms.Label lblFilterAutoId;
        private System.Windows.Forms.ComboBox cmbClientId;
        private System.Windows.Forms.Label lblFilterClientId;
        private System.Windows.Forms.Label lblComenzi;
    }
}