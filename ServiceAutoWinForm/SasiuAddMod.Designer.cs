namespace ServiceAutoWinForm
{
    partial class SasiuAddMod
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddModSasiu = new System.Windows.Forms.Button();
            this.lblSasiu = new System.Windows.Forms.Label();
            this.txtDenumire = new System.Windows.Forms.TextBox();
            this.txtCodSasiu = new System.Windows.Forms.TextBox();
            this.txtSasiuId = new System.Windows.Forms.TextBox();
            this.lblDenumire = new System.Windows.Forms.Label();
            this.lblCodSasiu = new System.Windows.Forms.Label();
            this.lblSasiuId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(277, 114);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(153, 23);
            this.btnExit.TabIndex = 55;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddModSasiu
            // 
            this.btnAddModSasiu.Location = new System.Drawing.Point(17, 114);
            this.btnAddModSasiu.Name = "btnAddModSasiu";
            this.btnAddModSasiu.Size = new System.Drawing.Size(153, 23);
            this.btnAddModSasiu.TabIndex = 54;
            this.btnAddModSasiu.Text = "AddMod";
            this.btnAddModSasiu.UseVisualStyleBackColor = true;
            this.btnAddModSasiu.Click += new System.EventHandler(this.btnAddModSasiu_Click);
            // 
            // lblSasiu
            // 
            this.lblSasiu.AutoSize = true;
            this.lblSasiu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSasiu.Location = new System.Drawing.Point(193, 9);
            this.lblSasiu.Name = "lblSasiu";
            this.lblSasiu.Size = new System.Drawing.Size(56, 24);
            this.lblSasiu.TabIndex = 53;
            this.lblSasiu.Text = "Sasiu";
            // 
            // txtDenumire
            // 
            this.txtDenumire.Location = new System.Drawing.Point(98, 88);
            this.txtDenumire.MaxLength = 25;
            this.txtDenumire.Name = "txtDenumire";
            this.txtDenumire.Size = new System.Drawing.Size(332, 20);
            this.txtDenumire.TabIndex = 52;
            // 
            // txtCodSasiu
            // 
            this.txtCodSasiu.Location = new System.Drawing.Point(98, 62);
            this.txtCodSasiu.MaxLength = 2;
            this.txtCodSasiu.Name = "txtCodSasiu";
            this.txtCodSasiu.Size = new System.Drawing.Size(332, 20);
            this.txtCodSasiu.TabIndex = 51;
            // 
            // txtSasiuId
            // 
            this.txtSasiuId.Enabled = false;
            this.txtSasiuId.Location = new System.Drawing.Point(98, 36);
            this.txtSasiuId.Name = "txtSasiuId";
            this.txtSasiuId.Size = new System.Drawing.Size(332, 20);
            this.txtSasiuId.TabIndex = 50;
            // 
            // lblDenumire
            // 
            this.lblDenumire.AutoSize = true;
            this.lblDenumire.Location = new System.Drawing.Point(14, 91);
            this.lblDenumire.Name = "lblDenumire";
            this.lblDenumire.Size = new System.Drawing.Size(55, 13);
            this.lblDenumire.TabIndex = 49;
            this.lblDenumire.Text = "Denumire:";
            // 
            // lblCodSasiu
            // 
            this.lblCodSasiu.AutoSize = true;
            this.lblCodSasiu.Location = new System.Drawing.Point(14, 65);
            this.lblCodSasiu.Name = "lblCodSasiu";
            this.lblCodSasiu.Size = new System.Drawing.Size(58, 13);
            this.lblCodSasiu.TabIndex = 47;
            this.lblCodSasiu.Text = "Cod Sasiu:";
            // 
            // lblSasiuId
            // 
            this.lblSasiuId.AutoSize = true;
            this.lblSasiuId.Location = new System.Drawing.Point(14, 39);
            this.lblSasiuId.Name = "lblSasiuId";
            this.lblSasiuId.Size = new System.Drawing.Size(19, 13);
            this.lblSasiuId.TabIndex = 46;
            this.lblSasiuId.Text = "Id:";
            // 
            // SasiuAddMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 153);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddModSasiu);
            this.Controls.Add(this.lblSasiu);
            this.Controls.Add(this.txtDenumire);
            this.Controls.Add(this.txtCodSasiu);
            this.Controls.Add(this.txtSasiuId);
            this.Controls.Add(this.lblDenumire);
            this.Controls.Add(this.lblCodSasiu);
            this.Controls.Add(this.lblSasiuId);
            this.Name = "SasiuAddMod";
            this.Text = "SasiuAddMod";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddModSasiu;
        private System.Windows.Forms.Label lblSasiu;
        private System.Windows.Forms.TextBox txtDenumire;
        private System.Windows.Forms.TextBox txtCodSasiu;
        private System.Windows.Forms.TextBox txtSasiuId;
        private System.Windows.Forms.Label lblDenumire;
        private System.Windows.Forms.Label lblCodSasiu;
        private System.Windows.Forms.Label lblSasiuId;
    }
}