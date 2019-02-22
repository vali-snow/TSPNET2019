namespace Agenda
{
    partial class AgendaForm
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
            this.lblNume = new System.Windows.Forms.Label();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.lblPrenume = new System.Windows.Forms.Label();
            this.txtPrenume = new System.Windows.Forms.TextBox();
            this.lblVarsta = new System.Windows.Forms.Label();
            this.txtVarsta = new System.Windows.Forms.TextBox();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnAddNewContact = new System.Windows.Forms.Button();
            this.dgwAgenda = new System.Windows.Forms.DataGridView();
            this.grbAddNewContact = new System.Windows.Forms.GroupBox();
            this.btnClearForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAgenda)).BeginInit();
            this.grbAddNewContact.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Location = new System.Drawing.Point(43, 40);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(35, 13);
            this.lblNume.TabIndex = 3;
            this.lblNume.Text = "Nume";
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(101, 37);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(169, 20);
            this.txtNume.TabIndex = 2;
            // 
            // lblPrenume
            // 
            this.lblPrenume.AutoSize = true;
            this.lblPrenume.Location = new System.Drawing.Point(43, 66);
            this.lblPrenume.Name = "lblPrenume";
            this.lblPrenume.Size = new System.Drawing.Size(49, 13);
            this.lblPrenume.TabIndex = 5;
            this.lblPrenume.Text = "Prenume";
            // 
            // txtPrenume
            // 
            this.txtPrenume.Location = new System.Drawing.Point(101, 63);
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.Size = new System.Drawing.Size(169, 20);
            this.txtPrenume.TabIndex = 4;
            // 
            // lblVarsta
            // 
            this.lblVarsta.AutoSize = true;
            this.lblVarsta.Location = new System.Drawing.Point(43, 92);
            this.lblVarsta.Name = "lblVarsta";
            this.lblVarsta.Size = new System.Drawing.Size(37, 13);
            this.lblVarsta.TabIndex = 7;
            this.lblVarsta.Text = "Varsta";
            // 
            // txtVarsta
            // 
            this.txtVarsta.Location = new System.Drawing.Point(101, 89);
            this.txtVarsta.Name = "txtVarsta";
            this.txtVarsta.Size = new System.Drawing.Size(169, 20);
            this.txtVarsta.TabIndex = 6;
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(43, 118);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(43, 13);
            this.lblTelefon.TabIndex = 9;
            this.lblTelefon.Text = "Telefon";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(101, 115);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(169, 20);
            this.txtTelefon.TabIndex = 8;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(43, 144);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(101, 141);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(169, 20);
            this.txtEmail.TabIndex = 10;
            // 
            // btnAddNewContact
            // 
            this.btnAddNewContact.Location = new System.Drawing.Point(46, 185);
            this.btnAddNewContact.Name = "btnAddNewContact";
            this.btnAddNewContact.Size = new System.Drawing.Size(75, 23);
            this.btnAddNewContact.TabIndex = 12;
            this.btnAddNewContact.Text = "Add";
            this.btnAddNewContact.UseVisualStyleBackColor = true;
            this.btnAddNewContact.Click += new System.EventHandler(this.btnAddNewContact_Click);
            // 
            // dgwAgenda
            // 
            this.dgwAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwAgenda.Location = new System.Drawing.Point(603, 86);
            this.dgwAgenda.Name = "dgwAgenda";
            this.dgwAgenda.Size = new System.Drawing.Size(471, 292);
            this.dgwAgenda.TabIndex = 13;
            // 
            // grbAddNewContact
            // 
            this.grbAddNewContact.Controls.Add(this.btnClearForm);
            this.grbAddNewContact.Controls.Add(this.lblNume);
            this.grbAddNewContact.Controls.Add(this.txtNume);
            this.grbAddNewContact.Controls.Add(this.btnAddNewContact);
            this.grbAddNewContact.Controls.Add(this.txtPrenume);
            this.grbAddNewContact.Controls.Add(this.lblEmail);
            this.grbAddNewContact.Controls.Add(this.lblPrenume);
            this.grbAddNewContact.Controls.Add(this.txtEmail);
            this.grbAddNewContact.Controls.Add(this.txtVarsta);
            this.grbAddNewContact.Controls.Add(this.lblTelefon);
            this.grbAddNewContact.Controls.Add(this.lblVarsta);
            this.grbAddNewContact.Controls.Add(this.txtTelefon);
            this.grbAddNewContact.Location = new System.Drawing.Point(61, 86);
            this.grbAddNewContact.Name = "grbAddNewContact";
            this.grbAddNewContact.Size = new System.Drawing.Size(314, 233);
            this.grbAddNewContact.TabIndex = 14;
            this.grbAddNewContact.TabStop = false;
            this.grbAddNewContact.Text = "Add New Contact";
            // 
            // btnClearForm
            // 
            this.btnClearForm.Location = new System.Drawing.Point(195, 185);
            this.btnClearForm.Name = "btnClearForm";
            this.btnClearForm.Size = new System.Drawing.Size(75, 23);
            this.btnClearForm.TabIndex = 13;
            this.btnClearForm.Text = "Clear";
            this.btnClearForm.UseVisualStyleBackColor = true;
            this.btnClearForm.Click += new System.EventHandler(this.btnClearForm_Click);
            // 
            // AgendaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 720);
            this.Controls.Add(this.grbAddNewContact);
            this.Controls.Add(this.dgwAgenda);
            this.Name = "AgendaForm";
            this.Text = "Agenda";
            ((System.ComponentModel.ISupportInitialize)(this.dgwAgenda)).EndInit();
            this.grbAddNewContact.ResumeLayout(false);
            this.grbAddNewContact.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.Label lblPrenume;
        private System.Windows.Forms.TextBox txtPrenume;
        private System.Windows.Forms.Label lblVarsta;
        private System.Windows.Forms.TextBox txtVarsta;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnAddNewContact;
        private System.Windows.Forms.DataGridView dgwAgenda;
        private System.Windows.Forms.GroupBox grbAddNewContact;
        private System.Windows.Forms.Button btnClearForm;
    }
}

