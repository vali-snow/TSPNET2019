namespace ServiceAutoWinForm
{
    partial class Sasiuri
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
            this.dataGridViewSasiuri = new System.Windows.Forms.DataGridView();
            this.lblSasiuri = new System.Windows.Forms.Label();
            this.btnLinkAutoturisme = new System.Windows.Forms.Button();
            this.btnRefreshSasiuri = new System.Windows.Forms.Button();
            this.btnExitSasiuri = new System.Windows.Forms.Button();
            this.btnRemoveSelectedSasiuri = new System.Windows.Forms.Button();
            this.btnModifySelectedSasiu = new System.Windows.Forms.Button();
            this.btnAddSasiu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSasiuri)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSasiuri
            // 
            this.dataGridViewSasiuri.AllowUserToAddRows = false;
            this.dataGridViewSasiuri.AllowUserToDeleteRows = false;
            this.dataGridViewSasiuri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSasiuri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSasiuri.Location = new System.Drawing.Point(12, 39);
            this.dataGridViewSasiuri.Name = "dataGridViewSasiuri";
            this.dataGridViewSasiuri.ReadOnly = true;
            this.dataGridViewSasiuri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSasiuri.Size = new System.Drawing.Size(852, 415);
            this.dataGridViewSasiuri.TabIndex = 20;
            this.dataGridViewSasiuri.SelectionChanged += new System.EventHandler(this.dataGridViewSasiuri_SelectionChanged);
            // 
            // lblSasiuri
            // 
            this.lblSasiuri.AutoSize = true;
            this.lblSasiuri.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSasiuri.Location = new System.Drawing.Point(394, 12);
            this.lblSasiuri.Name = "lblSasiuri";
            this.lblSasiuri.Size = new System.Drawing.Size(66, 24);
            this.lblSasiuri.TabIndex = 19;
            this.lblSasiuri.Text = "Sasiuri";
            // 
            // btnLinkAutoturisme
            // 
            this.btnLinkAutoturisme.Location = new System.Drawing.Point(12, 460);
            this.btnLinkAutoturisme.Name = "btnLinkAutoturisme";
            this.btnLinkAutoturisme.Size = new System.Drawing.Size(155, 23);
            this.btnLinkAutoturisme.TabIndex = 39;
            this.btnLinkAutoturisme.Text = "Link Autoturisme";
            this.btnLinkAutoturisme.UseVisualStyleBackColor = true;
            this.btnLinkAutoturisme.Click += new System.EventHandler(this.btnLinkAutoturisme_Click);
            // 
            // btnRefreshSasiuri
            // 
            this.btnRefreshSasiuri.Location = new System.Drawing.Point(12, 489);
            this.btnRefreshSasiuri.Name = "btnRefreshSasiuri";
            this.btnRefreshSasiuri.Size = new System.Drawing.Size(155, 23);
            this.btnRefreshSasiuri.TabIndex = 38;
            this.btnRefreshSasiuri.Text = "Refresh";
            this.btnRefreshSasiuri.UseVisualStyleBackColor = true;
            this.btnRefreshSasiuri.Click += new System.EventHandler(this.btnRefreshSasiuri_Click);
            // 
            // btnExitSasiuri
            // 
            this.btnExitSasiuri.Location = new System.Drawing.Point(708, 489);
            this.btnExitSasiuri.Name = "btnExitSasiuri";
            this.btnExitSasiuri.Size = new System.Drawing.Size(155, 23);
            this.btnExitSasiuri.TabIndex = 37;
            this.btnExitSasiuri.Text = "Exit";
            this.btnExitSasiuri.UseVisualStyleBackColor = true;
            this.btnExitSasiuri.Click += new System.EventHandler(this.btnExitSasiuri_Click);
            // 
            // btnRemoveSelectedSasiuri
            // 
            this.btnRemoveSelectedSasiuri.Location = new System.Drawing.Point(708, 460);
            this.btnRemoveSelectedSasiuri.Name = "btnRemoveSelectedSasiuri";
            this.btnRemoveSelectedSasiuri.Size = new System.Drawing.Size(155, 23);
            this.btnRemoveSelectedSasiuri.TabIndex = 36;
            this.btnRemoveSelectedSasiuri.Text = "Remove Selected";
            this.btnRemoveSelectedSasiuri.UseVisualStyleBackColor = true;
            this.btnRemoveSelectedSasiuri.Click += new System.EventHandler(this.btnRemoveSelectedSasiuri_Click);
            // 
            // btnModifySelectedSasiu
            // 
            this.btnModifySelectedSasiu.Location = new System.Drawing.Point(360, 460);
            this.btnModifySelectedSasiu.Name = "btnModifySelectedSasiu";
            this.btnModifySelectedSasiu.Size = new System.Drawing.Size(155, 23);
            this.btnModifySelectedSasiu.TabIndex = 35;
            this.btnModifySelectedSasiu.Text = "Modify Selected";
            this.btnModifySelectedSasiu.UseVisualStyleBackColor = true;
            this.btnModifySelectedSasiu.Click += new System.EventHandler(this.btnModifySelectedSasiu_Click);
            // 
            // btnAddSasiu
            // 
            this.btnAddSasiu.Location = new System.Drawing.Point(360, 489);
            this.btnAddSasiu.Name = "btnAddSasiu";
            this.btnAddSasiu.Size = new System.Drawing.Size(155, 23);
            this.btnAddSasiu.TabIndex = 34;
            this.btnAddSasiu.Text = "Add New";
            this.btnAddSasiu.UseVisualStyleBackColor = true;
            this.btnAddSasiu.Click += new System.EventHandler(this.btnAddSasiu_Click);
            // 
            // Sasiuri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 523);
            this.Controls.Add(this.btnLinkAutoturisme);
            this.Controls.Add(this.btnRefreshSasiuri);
            this.Controls.Add(this.btnExitSasiuri);
            this.Controls.Add(this.btnRemoveSelectedSasiuri);
            this.Controls.Add(this.btnModifySelectedSasiu);
            this.Controls.Add(this.btnAddSasiu);
            this.Controls.Add(this.dataGridViewSasiuri);
            this.Controls.Add(this.lblSasiuri);
            this.Name = "Sasiuri";
            this.Text = "Sasiuri";
            this.Load += new System.EventHandler(this.Sasiuri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSasiuri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewSasiuri;
        private System.Windows.Forms.Label lblSasiuri;
        private System.Windows.Forms.Button btnLinkAutoturisme;
        private System.Windows.Forms.Button btnRefreshSasiuri;
        private System.Windows.Forms.Button btnExitSasiuri;
        private System.Windows.Forms.Button btnRemoveSelectedSasiuri;
        private System.Windows.Forms.Button btnModifySelectedSasiu;
        private System.Windows.Forms.Button btnAddSasiu;
    }
}