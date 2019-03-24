namespace ServiceAutoWinForm
{
    partial class Autoturisme
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
            this.lblAutoturisme = new System.Windows.Forms.Label();
            this.cmbClientId = new System.Windows.Forms.ComboBox();
            this.lblFilterClientId = new System.Windows.Forms.Label();
            this.cmbSasiuId = new System.Windows.Forms.ComboBox();
            this.lblFilterSasiuId = new System.Windows.Forms.Label();
            this.btnRefreshAutoturisme = new System.Windows.Forms.Button();
            this.btnExitAutoturisme = new System.Windows.Forms.Button();
            this.btnRemoveSelectedAutoturisme = new System.Windows.Forms.Button();
            this.btnModifySelectedAutoturism = new System.Windows.Forms.Button();
            this.btnAddAutoturism = new System.Windows.Forms.Button();
            this.dataGridViewAutoturisme = new System.Windows.Forms.DataGridView();
            this.btnClearFilters = new System.Windows.Forms.Button();
            this.btnLinkComenzi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAutoturisme)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAutoturisme
            // 
            this.lblAutoturisme.AutoSize = true;
            this.lblAutoturisme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutoturisme.Location = new System.Drawing.Point(445, 9);
            this.lblAutoturisme.Name = "lblAutoturisme";
            this.lblAutoturisme.Size = new System.Drawing.Size(110, 24);
            this.lblAutoturisme.TabIndex = 11;
            this.lblAutoturisme.Text = "Autoturisme";
            // 
            // cmbClientId
            // 
            this.cmbClientId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClientId.FormattingEnabled = true;
            this.cmbClientId.Location = new System.Drawing.Point(63, 38);
            this.cmbClientId.Name = "cmbClientId";
            this.cmbClientId.Size = new System.Drawing.Size(156, 21);
            this.cmbClientId.TabIndex = 21;
            this.cmbClientId.SelectionChangeCommitted += new System.EventHandler(this.cmbClientId_SelectionChangeCommitted);
            // 
            // lblFilterClientId
            // 
            this.lblFilterClientId.AutoSize = true;
            this.lblFilterClientId.Location = new System.Drawing.Point(12, 41);
            this.lblFilterClientId.Name = "lblFilterClientId";
            this.lblFilterClientId.Size = new System.Drawing.Size(45, 13);
            this.lblFilterClientId.TabIndex = 20;
            this.lblFilterClientId.Text = "ClientId:";
            // 
            // cmbSasiuId
            // 
            this.cmbSasiuId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSasiuId.FormattingEnabled = true;
            this.cmbSasiuId.Location = new System.Drawing.Point(310, 38);
            this.cmbSasiuId.Name = "cmbSasiuId";
            this.cmbSasiuId.Size = new System.Drawing.Size(156, 21);
            this.cmbSasiuId.TabIndex = 23;
            this.cmbSasiuId.SelectionChangeCommitted += new System.EventHandler(this.cmbSasiuId_SelectionChangeCommitted);
            // 
            // lblFilterSasiuId
            // 
            this.lblFilterSasiuId.AutoSize = true;
            this.lblFilterSasiuId.Location = new System.Drawing.Point(259, 41);
            this.lblFilterSasiuId.Name = "lblFilterSasiuId";
            this.lblFilterSasiuId.Size = new System.Drawing.Size(45, 13);
            this.lblFilterSasiuId.TabIndex = 22;
            this.lblFilterSasiuId.Text = "SasiuId:";
            // 
            // btnRefreshAutoturisme
            // 
            this.btnRefreshAutoturisme.Location = new System.Drawing.Point(12, 515);
            this.btnRefreshAutoturisme.Name = "btnRefreshAutoturisme";
            this.btnRefreshAutoturisme.Size = new System.Drawing.Size(155, 23);
            this.btnRefreshAutoturisme.TabIndex = 30;
            this.btnRefreshAutoturisme.Text = "Refresh";
            this.btnRefreshAutoturisme.UseVisualStyleBackColor = true;
            this.btnRefreshAutoturisme.Click += new System.EventHandler(this.btnRefreshAutoturisme_Click);
            // 
            // btnExitAutoturisme
            // 
            this.btnExitAutoturisme.Location = new System.Drawing.Point(708, 515);
            this.btnExitAutoturisme.Name = "btnExitAutoturisme";
            this.btnExitAutoturisme.Size = new System.Drawing.Size(155, 23);
            this.btnExitAutoturisme.TabIndex = 29;
            this.btnExitAutoturisme.Text = "Exit";
            this.btnExitAutoturisme.UseVisualStyleBackColor = true;
            this.btnExitAutoturisme.Click += new System.EventHandler(this.btnExitAutoturisme_Click);
            // 
            // btnRemoveSelectedAutoturisme
            // 
            this.btnRemoveSelectedAutoturisme.Location = new System.Drawing.Point(708, 486);
            this.btnRemoveSelectedAutoturisme.Name = "btnRemoveSelectedAutoturisme";
            this.btnRemoveSelectedAutoturisme.Size = new System.Drawing.Size(155, 23);
            this.btnRemoveSelectedAutoturisme.TabIndex = 28;
            this.btnRemoveSelectedAutoturisme.Text = "Remove Selected";
            this.btnRemoveSelectedAutoturisme.UseVisualStyleBackColor = true;
            this.btnRemoveSelectedAutoturisme.Click += new System.EventHandler(this.btnRemoveSelectedAutoturisme_Click);
            // 
            // btnModifySelectedAutoturism
            // 
            this.btnModifySelectedAutoturism.Location = new System.Drawing.Point(360, 486);
            this.btnModifySelectedAutoturism.Name = "btnModifySelectedAutoturism";
            this.btnModifySelectedAutoturism.Size = new System.Drawing.Size(155, 23);
            this.btnModifySelectedAutoturism.TabIndex = 27;
            this.btnModifySelectedAutoturism.Text = "Modify Selected";
            this.btnModifySelectedAutoturism.UseVisualStyleBackColor = true;
            this.btnModifySelectedAutoturism.Click += new System.EventHandler(this.btnModifySelectedAutoturism_Click);
            // 
            // btnAddAutoturism
            // 
            this.btnAddAutoturism.Location = new System.Drawing.Point(360, 515);
            this.btnAddAutoturism.Name = "btnAddAutoturism";
            this.btnAddAutoturism.Size = new System.Drawing.Size(155, 23);
            this.btnAddAutoturism.TabIndex = 26;
            this.btnAddAutoturism.Text = "Add New";
            this.btnAddAutoturism.UseVisualStyleBackColor = true;
            this.btnAddAutoturism.Click += new System.EventHandler(this.btnAddAutoturism_Click);
            // 
            // dataGridViewAutoturisme
            // 
            this.dataGridViewAutoturisme.AllowUserToAddRows = false;
            this.dataGridViewAutoturisme.AllowUserToDeleteRows = false;
            this.dataGridViewAutoturisme.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAutoturisme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAutoturisme.Location = new System.Drawing.Point(12, 65);
            this.dataGridViewAutoturisme.Name = "dataGridViewAutoturisme";
            this.dataGridViewAutoturisme.ReadOnly = true;
            this.dataGridViewAutoturisme.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAutoturisme.Size = new System.Drawing.Size(852, 415);
            this.dataGridViewAutoturisme.TabIndex = 25;
            this.dataGridViewAutoturisme.SelectionChanged += new System.EventHandler(this.dataGridViewAutoturisme_SelectionChanged);
            // 
            // btnClearFilters
            // 
            this.btnClearFilters.Location = new System.Drawing.Point(534, 36);
            this.btnClearFilters.Name = "btnClearFilters";
            this.btnClearFilters.Size = new System.Drawing.Size(155, 23);
            this.btnClearFilters.TabIndex = 31;
            this.btnClearFilters.Text = "Clear Filters";
            this.btnClearFilters.UseVisualStyleBackColor = true;
            this.btnClearFilters.Click += new System.EventHandler(this.btnClearFilters_Click);
            // 
            // btnLinkComenzi
            // 
            this.btnLinkComenzi.Location = new System.Drawing.Point(12, 486);
            this.btnLinkComenzi.Name = "btnLinkComenzi";
            this.btnLinkComenzi.Size = new System.Drawing.Size(155, 23);
            this.btnLinkComenzi.TabIndex = 33;
            this.btnLinkComenzi.Text = "Link Comenzi";
            this.btnLinkComenzi.UseVisualStyleBackColor = true;
            this.btnLinkComenzi.Click += new System.EventHandler(this.btnLinkComenzi_Click);
            // 
            // Autoturisme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 549);
            this.Controls.Add(this.btnLinkComenzi);
            this.Controls.Add(this.btnClearFilters);
            this.Controls.Add(this.btnRefreshAutoturisme);
            this.Controls.Add(this.btnExitAutoturisme);
            this.Controls.Add(this.btnRemoveSelectedAutoturisme);
            this.Controls.Add(this.btnModifySelectedAutoturism);
            this.Controls.Add(this.btnAddAutoturism);
            this.Controls.Add(this.dataGridViewAutoturisme);
            this.Controls.Add(this.cmbSasiuId);
            this.Controls.Add(this.lblFilterSasiuId);
            this.Controls.Add(this.cmbClientId);
            this.Controls.Add(this.lblFilterClientId);
            this.Controls.Add(this.lblAutoturisme);
            this.Name = "Autoturisme";
            this.Text = "Autoturisme";
            this.Load += new System.EventHandler(this.Autoturisme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAutoturisme)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAutoturisme;
        private System.Windows.Forms.ComboBox cmbClientId;
        private System.Windows.Forms.Label lblFilterClientId;
        private System.Windows.Forms.ComboBox cmbSasiuId;
        private System.Windows.Forms.Label lblFilterSasiuId;
        private System.Windows.Forms.Button btnRefreshAutoturisme;
        private System.Windows.Forms.Button btnExitAutoturisme;
        private System.Windows.Forms.Button btnRemoveSelectedAutoturisme;
        private System.Windows.Forms.Button btnModifySelectedAutoturism;
        private System.Windows.Forms.Button btnAddAutoturism;
        private System.Windows.Forms.DataGridView dataGridViewAutoturisme;
        private System.Windows.Forms.Button btnClearFilters;
        private System.Windows.Forms.Button btnLinkComenzi;
    }
}