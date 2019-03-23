namespace ServiceAutoWinForm
{
    partial class ClientiAddMod
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
            this.lblNume = new System.Windows.Forms.Label();
            this.lblPrenume = new System.Windows.Forms.Label();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.lblJudet = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.txtClientId = new System.Windows.Forms.TextBox();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtPrenume = new System.Windows.Forms.TextBox();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.cmbJudet = new System.Windows.Forms.ComboBox();
            this.lblClient = new System.Windows.Forms.Label();
            this.btnAddModClient = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblLocalitate = new System.Windows.Forms.Label();
            this.txtLocalitate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblClientId
            // 
            this.lblClientId.AutoSize = true;
            this.lblClientId.Location = new System.Drawing.Point(12, 39);
            this.lblClientId.Name = "lblClientId";
            this.lblClientId.Size = new System.Drawing.Size(19, 13);
            this.lblClientId.TabIndex = 0;
            this.lblClientId.Text = "Id:";
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Location = new System.Drawing.Point(12, 65);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(38, 13);
            this.lblNume.TabIndex = 1;
            this.lblNume.Text = "Nume:";
            // 
            // lblPrenume
            // 
            this.lblPrenume.AutoSize = true;
            this.lblPrenume.Location = new System.Drawing.Point(12, 91);
            this.lblPrenume.Name = "lblPrenume";
            this.lblPrenume.Size = new System.Drawing.Size(52, 13);
            this.lblPrenume.TabIndex = 2;
            this.lblPrenume.Text = "Prenume:";
            // 
            // lblAdresa
            // 
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.Location = new System.Drawing.Point(12, 117);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(43, 13);
            this.lblAdresa.TabIndex = 3;
            this.lblAdresa.Text = "Adresa:";
            // 
            // lblJudet
            // 
            this.lblJudet.AutoSize = true;
            this.lblJudet.Location = new System.Drawing.Point(12, 170);
            this.lblJudet.Name = "lblJudet";
            this.lblJudet.Size = new System.Drawing.Size(36, 13);
            this.lblJudet.TabIndex = 4;
            this.lblJudet.Text = "Judet:";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(12, 196);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(46, 13);
            this.lblTelefon.TabIndex = 5;
            this.lblTelefon.Text = "Telefon:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(12, 222);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email:";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(96, 193);
            this.txtTelefon.Mask = "9990000000000";
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(332, 20);
            this.txtTelefon.TabIndex = 12;
            this.txtTelefon.ValidatingType = typeof(int);
            // 
            // txtClientId
            // 
            this.txtClientId.Enabled = false;
            this.txtClientId.Location = new System.Drawing.Point(96, 36);
            this.txtClientId.Name = "txtClientId";
            this.txtClientId.Size = new System.Drawing.Size(332, 20);
            this.txtClientId.TabIndex = 13;
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(96, 62);
            this.txtNume.MaxLength = 15;
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(332, 20);
            this.txtNume.TabIndex = 14;
            // 
            // txtPrenume
            // 
            this.txtPrenume.Location = new System.Drawing.Point(96, 88);
            this.txtPrenume.MaxLength = 15;
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.Size = new System.Drawing.Size(332, 20);
            this.txtPrenume.TabIndex = 15;
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(96, 114);
            this.txtAdresa.MaxLength = 50;
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(332, 20);
            this.txtAdresa.TabIndex = 16;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(96, 219);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(332, 20);
            this.txtEmail.TabIndex = 18;
            // 
            // cmbJudet
            // 
            this.cmbJudet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJudet.FormattingEnabled = true;
            this.cmbJudet.Location = new System.Drawing.Point(96, 166);
            this.cmbJudet.Name = "cmbJudet";
            this.cmbJudet.Size = new System.Drawing.Size(332, 21);
            this.cmbJudet.TabIndex = 19;
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClient.Location = new System.Drawing.Point(191, 9);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(57, 24);
            this.lblClient.TabIndex = 20;
            this.lblClient.Text = "Client";
            // 
            // btnAddModClient
            // 
            this.btnAddModClient.Location = new System.Drawing.Point(15, 254);
            this.btnAddModClient.Name = "btnAddModClient";
            this.btnAddModClient.Size = new System.Drawing.Size(153, 23);
            this.btnAddModClient.TabIndex = 21;
            this.btnAddModClient.Text = "AddMod";
            this.btnAddModClient.UseVisualStyleBackColor = true;
            this.btnAddModClient.Click += new System.EventHandler(this.btnAddModClient_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(275, 254);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(153, 23);
            this.btnExit.TabIndex = 22;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblLocalitate
            // 
            this.lblLocalitate.AutoSize = true;
            this.lblLocalitate.Location = new System.Drawing.Point(12, 143);
            this.lblLocalitate.Name = "lblLocalitate";
            this.lblLocalitate.Size = new System.Drawing.Size(56, 13);
            this.lblLocalitate.TabIndex = 23;
            this.lblLocalitate.Text = "Localitate:";
            // 
            // txtLocalitate
            // 
            this.txtLocalitate.Location = new System.Drawing.Point(96, 140);
            this.txtLocalitate.MaxLength = 15;
            this.txtLocalitate.Name = "txtLocalitate";
            this.txtLocalitate.Size = new System.Drawing.Size(332, 20);
            this.txtLocalitate.TabIndex = 24;
            // 
            // ClientiAddMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 489);
            this.Controls.Add(this.txtLocalitate);
            this.Controls.Add(this.lblLocalitate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddModClient);
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.cmbJudet);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.txtPrenume);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.txtClientId);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.lblJudet);
            this.Controls.Add(this.lblAdresa);
            this.Controls.Add(this.lblPrenume);
            this.Controls.Add(this.lblNume);
            this.Controls.Add(this.lblClientId);
            this.Name = "ClientiAddMod";
            this.Text = "ClientiAddMod";
            this.Load += new System.EventHandler(this.ClientiAddMod_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClientId;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.Label lblPrenume;
        private System.Windows.Forms.Label lblAdresa;
        private System.Windows.Forms.Label lblJudet;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.MaskedTextBox txtTelefon;
        private System.Windows.Forms.TextBox txtClientId;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.TextBox txtPrenume;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ComboBox cmbJudet;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.Button btnAddModClient;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblLocalitate;
        private System.Windows.Forms.TextBox txtLocalitate;
    }
}