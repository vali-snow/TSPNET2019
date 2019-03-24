namespace ServiceAutoWinForm
{
    partial class AutoAddMod
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
            this.lblClientId = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddModAuto = new System.Windows.Forms.Button();
            this.lblAuto = new System.Windows.Forms.Label();
            this.txtSerieSasiu = new System.Windows.Forms.TextBox();
            this.txtNumarAuto = new System.Windows.Forms.TextBox();
            this.txtAutoId = new System.Windows.Forms.TextBox();
            this.lblSerieSasiu = new System.Windows.Forms.Label();
            this.lblSasiuId = new System.Windows.Forms.Label();
            this.lblNumarAuto = new System.Windows.Forms.Label();
            this.lblAutoId = new System.Windows.Forms.Label();
            this.cmbSasiuId = new System.Windows.Forms.ComboBox();
            this.cmbClientId = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblClientId
            // 
            this.lblClientId.AutoSize = true;
            this.lblClientId.Location = new System.Drawing.Point(14, 147);
            this.lblClientId.Name = "lblClientId";
            this.lblClientId.Size = new System.Drawing.Size(45, 13);
            this.lblClientId.TabIndex = 42;
            this.lblClientId.Text = "ClientId:";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(277, 171);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(153, 23);
            this.btnExit.TabIndex = 41;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddModAuto
            // 
            this.btnAddModAuto.Location = new System.Drawing.Point(17, 171);
            this.btnAddModAuto.Name = "btnAddModAuto";
            this.btnAddModAuto.Size = new System.Drawing.Size(153, 23);
            this.btnAddModAuto.TabIndex = 40;
            this.btnAddModAuto.Text = "AddMod";
            this.btnAddModAuto.UseVisualStyleBackColor = true;
            this.btnAddModAuto.Click += new System.EventHandler(this.btnAddModAuto_Click);
            // 
            // lblAuto
            // 
            this.lblAuto.AutoSize = true;
            this.lblAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuto.Location = new System.Drawing.Point(193, 13);
            this.lblAuto.Name = "lblAuto";
            this.lblAuto.Size = new System.Drawing.Size(49, 24);
            this.lblAuto.TabIndex = 39;
            this.lblAuto.Text = "Auto";
            // 
            // txtSerieSasiu
            // 
            this.txtSerieSasiu.Location = new System.Drawing.Point(98, 118);
            this.txtSerieSasiu.MaxLength = 25;
            this.txtSerieSasiu.Name = "txtSerieSasiu";
            this.txtSerieSasiu.Size = new System.Drawing.Size(332, 20);
            this.txtSerieSasiu.TabIndex = 36;
            // 
            // txtNumarAuto
            // 
            this.txtNumarAuto.Location = new System.Drawing.Point(98, 66);
            this.txtNumarAuto.MaxLength = 10;
            this.txtNumarAuto.Name = "txtNumarAuto";
            this.txtNumarAuto.Size = new System.Drawing.Size(332, 20);
            this.txtNumarAuto.TabIndex = 34;
            // 
            // txtAutoId
            // 
            this.txtAutoId.Enabled = false;
            this.txtAutoId.Location = new System.Drawing.Point(98, 40);
            this.txtAutoId.Name = "txtAutoId";
            this.txtAutoId.Size = new System.Drawing.Size(332, 20);
            this.txtAutoId.TabIndex = 33;
            // 
            // lblSerieSasiu
            // 
            this.lblSerieSasiu.AutoSize = true;
            this.lblSerieSasiu.Location = new System.Drawing.Point(14, 121);
            this.lblSerieSasiu.Name = "lblSerieSasiu";
            this.lblSerieSasiu.Size = new System.Drawing.Size(63, 13);
            this.lblSerieSasiu.TabIndex = 28;
            this.lblSerieSasiu.Text = "Serie Sasiu:";
            // 
            // lblSasiuId
            // 
            this.lblSasiuId.AutoSize = true;
            this.lblSasiuId.Location = new System.Drawing.Point(14, 95);
            this.lblSasiuId.Name = "lblSasiuId";
            this.lblSasiuId.Size = new System.Drawing.Size(45, 13);
            this.lblSasiuId.TabIndex = 27;
            this.lblSasiuId.Text = "SasiuId:";
            // 
            // lblNumarAuto
            // 
            this.lblNumarAuto.AutoSize = true;
            this.lblNumarAuto.Location = new System.Drawing.Point(14, 69);
            this.lblNumarAuto.Name = "lblNumarAuto";
            this.lblNumarAuto.Size = new System.Drawing.Size(66, 13);
            this.lblNumarAuto.TabIndex = 26;
            this.lblNumarAuto.Text = "Numar Auto:";
            // 
            // lblAutoId
            // 
            this.lblAutoId.AutoSize = true;
            this.lblAutoId.Location = new System.Drawing.Point(14, 43);
            this.lblAutoId.Name = "lblAutoId";
            this.lblAutoId.Size = new System.Drawing.Size(19, 13);
            this.lblAutoId.TabIndex = 25;
            this.lblAutoId.Text = "Id:";
            // 
            // cmbSasiuId
            // 
            this.cmbSasiuId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSasiuId.FormattingEnabled = true;
            this.cmbSasiuId.Location = new System.Drawing.Point(98, 91);
            this.cmbSasiuId.Name = "cmbSasiuId";
            this.cmbSasiuId.Size = new System.Drawing.Size(332, 21);
            this.cmbSasiuId.TabIndex = 44;
            // 
            // cmbClientId
            // 
            this.cmbClientId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClientId.FormattingEnabled = true;
            this.cmbClientId.Location = new System.Drawing.Point(98, 144);
            this.cmbClientId.Name = "cmbClientId";
            this.cmbClientId.Size = new System.Drawing.Size(332, 21);
            this.cmbClientId.TabIndex = 45;
            // 
            // AutoAddMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbClientId);
            this.Controls.Add(this.cmbSasiuId);
            this.Controls.Add(this.lblClientId);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddModAuto);
            this.Controls.Add(this.lblAuto);
            this.Controls.Add(this.txtSerieSasiu);
            this.Controls.Add(this.txtNumarAuto);
            this.Controls.Add(this.txtAutoId);
            this.Controls.Add(this.lblSerieSasiu);
            this.Controls.Add(this.lblSasiuId);
            this.Controls.Add(this.lblNumarAuto);
            this.Controls.Add(this.lblAutoId);
            this.Name = "AutoAddMod";
            this.Text = "AutoAddMod";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblClientId;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddModAuto;
        private System.Windows.Forms.Label lblAuto;
        private System.Windows.Forms.TextBox txtSerieSasiu;
        private System.Windows.Forms.TextBox txtNumarAuto;
        private System.Windows.Forms.TextBox txtAutoId;
        private System.Windows.Forms.Label lblSerieSasiu;
        private System.Windows.Forms.Label lblSasiuId;
        private System.Windows.Forms.Label lblNumarAuto;
        private System.Windows.Forms.Label lblAutoId;
        private System.Windows.Forms.ComboBox cmbSasiuId;
        private System.Windows.Forms.ComboBox cmbClientId;
    }
}