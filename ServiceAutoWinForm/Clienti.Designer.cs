namespace ServiceAutoWinForm
{
    partial class Clienti
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
            this.lblClienti = new System.Windows.Forms.Label();
            this.dataGridViewClienti = new System.Windows.Forms.DataGridView();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.btnModifySelectedClient = new System.Windows.Forms.Button();
            this.btnRemoveSelectedClienti = new System.Windows.Forms.Button();
            this.btnExitClienti = new System.Windows.Forms.Button();
            this.btnRefreshClient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClienti)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClienti
            // 
            this.lblClienti.AutoSize = true;
            this.lblClienti.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienti.Location = new System.Drawing.Point(476, 3);
            this.lblClienti.Name = "lblClienti";
            this.lblClienti.Size = new System.Drawing.Size(61, 24);
            this.lblClienti.TabIndex = 10;
            this.lblClienti.Text = "Clienti";
            // 
            // dataGridViewClienti
            // 
            this.dataGridViewClienti.AllowUserToAddRows = false;
            this.dataGridViewClienti.AllowUserToDeleteRows = false;
            this.dataGridViewClienti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClienti.Location = new System.Drawing.Point(12, 30);
            this.dataGridViewClienti.Name = "dataGridViewClienti";
            this.dataGridViewClienti.ReadOnly = true;
            this.dataGridViewClienti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewClienti.Size = new System.Drawing.Size(989, 415);
            this.dataGridViewClienti.TabIndex = 11;
            this.dataGridViewClienti.SelectionChanged += new System.EventHandler(this.dataGridViewClienti_SelectionChanged);
            // 
            // btnAddClient
            // 
            this.btnAddClient.Location = new System.Drawing.Point(220, 451);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(155, 23);
            this.btnAddClient.TabIndex = 12;
            this.btnAddClient.Text = "Add";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // btnModifySelectedClient
            // 
            this.btnModifySelectedClient.Location = new System.Drawing.Point(428, 451);
            this.btnModifySelectedClient.Name = "btnModifySelectedClient";
            this.btnModifySelectedClient.Size = new System.Drawing.Size(155, 23);
            this.btnModifySelectedClient.TabIndex = 13;
            this.btnModifySelectedClient.Text = "Modify Selected";
            this.btnModifySelectedClient.UseVisualStyleBackColor = true;
            this.btnModifySelectedClient.Click += new System.EventHandler(this.btnModifySelectedClient_Click);
            // 
            // btnRemoveSelectedClienti
            // 
            this.btnRemoveSelectedClienti.Location = new System.Drawing.Point(636, 451);
            this.btnRemoveSelectedClienti.Name = "btnRemoveSelectedClienti";
            this.btnRemoveSelectedClienti.Size = new System.Drawing.Size(155, 23);
            this.btnRemoveSelectedClienti.TabIndex = 14;
            this.btnRemoveSelectedClienti.Text = "Remove Selected";
            this.btnRemoveSelectedClienti.UseVisualStyleBackColor = true;
            this.btnRemoveSelectedClienti.Click += new System.EventHandler(this.btnRemoveSelectedClienti_Click);
            // 
            // btnExitClienti
            // 
            this.btnExitClienti.Location = new System.Drawing.Point(846, 451);
            this.btnExitClienti.Name = "btnExitClienti";
            this.btnExitClienti.Size = new System.Drawing.Size(155, 23);
            this.btnExitClienti.TabIndex = 15;
            this.btnExitClienti.Text = "Exit";
            this.btnExitClienti.UseVisualStyleBackColor = true;
            this.btnExitClienti.Click += new System.EventHandler(this.btnExitClienti_Click);
            // 
            // btnRefreshClient
            // 
            this.btnRefreshClient.Location = new System.Drawing.Point(12, 451);
            this.btnRefreshClient.Name = "btnRefreshClient";
            this.btnRefreshClient.Size = new System.Drawing.Size(155, 23);
            this.btnRefreshClient.TabIndex = 16;
            this.btnRefreshClient.Text = "Refresh";
            this.btnRefreshClient.UseVisualStyleBackColor = true;
            this.btnRefreshClient.Click += new System.EventHandler(this.btnRefreshClient_Click);
            // 
            // Clienti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 483);
            this.Controls.Add(this.btnRefreshClient);
            this.Controls.Add(this.btnExitClienti);
            this.Controls.Add(this.btnRemoveSelectedClienti);
            this.Controls.Add(this.btnModifySelectedClient);
            this.Controls.Add(this.btnAddClient);
            this.Controls.Add(this.dataGridViewClienti);
            this.Controls.Add(this.lblClienti);
            this.Name = "Clienti";
            this.Text = "Clienti";
            this.Load += new System.EventHandler(this.Clienti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClienti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClienti;
        private System.Windows.Forms.DataGridView dataGridViewClienti;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Button btnModifySelectedClient;
        private System.Windows.Forms.Button btnRemoveSelectedClienti;
        private System.Windows.Forms.Button btnExitClienti;
        private System.Windows.Forms.Button btnRefreshClient;
    }
}