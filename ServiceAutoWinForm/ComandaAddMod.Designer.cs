namespace ServiceAutoWinForm
{
    partial class ComandaAddMod
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
            this.cmbClientId = new System.Windows.Forms.ComboBox();
            this.cmbAutoId = new System.Windows.Forms.ComboBox();
            this.lblClientId = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddModComanda = new System.Windows.Forms.Button();
            this.lblComanda = new System.Windows.Forms.Label();
            this.txtComandaId = new System.Windows.Forms.TextBox();
            this.lblKmBord = new System.Windows.Forms.Label();
            this.lblAutoId = new System.Windows.Forms.Label();
            this.lblStareComanda = new System.Windows.Forms.Label();
            this.lblComandaId = new System.Windows.Forms.Label();
            this.lblDataSystem = new System.Windows.Forms.Label();
            this.dtpDataSystem = new System.Windows.Forms.DateTimePicker();
            this.dtpDataProgramare = new System.Windows.Forms.DateTimePicker();
            this.lblDataProgramare = new System.Windows.Forms.Label();
            this.dtpDataFinalizare = new System.Windows.Forms.DateTimePicker();
            this.lblDataFinalizare = new System.Windows.Forms.Label();
            this.txtDescriere = new System.Windows.Forms.TextBox();
            this.lblDescriere = new System.Windows.Forms.Label();
            this.txtValoarePiese = new System.Windows.Forms.TextBox();
            this.lblValoarePiese = new System.Windows.Forms.Label();
            this.cmbStareComanda = new System.Windows.Forms.ComboBox();
            this.mtbKmBord = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // cmbClientId
            // 
            this.cmbClientId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClientId.FormattingEnabled = true;
            this.cmbClientId.Location = new System.Drawing.Point(137, 92);
            this.cmbClientId.Name = "cmbClientId";
            this.cmbClientId.Size = new System.Drawing.Size(332, 21);
            this.cmbClientId.TabIndex = 58;
            this.cmbClientId.SelectedIndexChanged += new System.EventHandler(this.cmbClientId_SelectedIndexChanged);
            // 
            // cmbAutoId
            // 
            this.cmbAutoId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAutoId.FormattingEnabled = true;
            this.cmbAutoId.Location = new System.Drawing.Point(137, 65);
            this.cmbAutoId.Name = "cmbAutoId";
            this.cmbAutoId.Size = new System.Drawing.Size(332, 21);
            this.cmbAutoId.TabIndex = 57;
            // 
            // lblClientId
            // 
            this.lblClientId.AutoSize = true;
            this.lblClientId.Location = new System.Drawing.Point(25, 95);
            this.lblClientId.Name = "lblClientId";
            this.lblClientId.Size = new System.Drawing.Size(45, 13);
            this.lblClientId.TabIndex = 56;
            this.lblClientId.Text = "ClientId:";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(316, 301);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(153, 23);
            this.btnExit.TabIndex = 55;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddModComanda
            // 
            this.btnAddModComanda.Location = new System.Drawing.Point(28, 301);
            this.btnAddModComanda.Name = "btnAddModComanda";
            this.btnAddModComanda.Size = new System.Drawing.Size(153, 23);
            this.btnAddModComanda.TabIndex = 54;
            this.btnAddModComanda.Text = "AddMod";
            this.btnAddModComanda.UseVisualStyleBackColor = true;
            this.btnAddModComanda.Click += new System.EventHandler(this.btnAddModComanda_Click);
            // 
            // lblComanda
            // 
            this.lblComanda.AutoSize = true;
            this.lblComanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComanda.Location = new System.Drawing.Point(205, 9);
            this.lblComanda.Name = "lblComanda";
            this.lblComanda.Size = new System.Drawing.Size(92, 24);
            this.lblComanda.TabIndex = 53;
            this.lblComanda.Text = "Comanda";
            // 
            // txtComandaId
            // 
            this.txtComandaId.Enabled = false;
            this.txtComandaId.Location = new System.Drawing.Point(137, 39);
            this.txtComandaId.Name = "txtComandaId";
            this.txtComandaId.Size = new System.Drawing.Size(332, 20);
            this.txtComandaId.TabIndex = 50;
            // 
            // lblKmBord
            // 
            this.lblKmBord.AutoSize = true;
            this.lblKmBord.Location = new System.Drawing.Point(25, 226);
            this.lblKmBord.Name = "lblKmBord";
            this.lblKmBord.Size = new System.Drawing.Size(50, 13);
            this.lblKmBord.TabIndex = 49;
            this.lblKmBord.Text = "Km Bord:";
            // 
            // lblAutoId
            // 
            this.lblAutoId.AutoSize = true;
            this.lblAutoId.Location = new System.Drawing.Point(25, 68);
            this.lblAutoId.Name = "lblAutoId";
            this.lblAutoId.Size = new System.Drawing.Size(41, 13);
            this.lblAutoId.TabIndex = 48;
            this.lblAutoId.Text = "AutoId:";
            // 
            // lblStareComanda
            // 
            this.lblStareComanda.AutoSize = true;
            this.lblStareComanda.Location = new System.Drawing.Point(25, 122);
            this.lblStareComanda.Name = "lblStareComanda";
            this.lblStareComanda.Size = new System.Drawing.Size(83, 13);
            this.lblStareComanda.TabIndex = 47;
            this.lblStareComanda.Text = "Stare Comanda:";
            // 
            // lblComandaId
            // 
            this.lblComandaId.AutoSize = true;
            this.lblComandaId.Location = new System.Drawing.Point(25, 39);
            this.lblComandaId.Name = "lblComandaId";
            this.lblComandaId.Size = new System.Drawing.Size(19, 13);
            this.lblComandaId.TabIndex = 46;
            this.lblComandaId.Text = "Id:";
            // 
            // lblDataSystem
            // 
            this.lblDataSystem.AutoSize = true;
            this.lblDataSystem.Location = new System.Drawing.Point(25, 148);
            this.lblDataSystem.Name = "lblDataSystem";
            this.lblDataSystem.Size = new System.Drawing.Size(70, 13);
            this.lblDataSystem.TabIndex = 59;
            this.lblDataSystem.Text = "Data System:";
            // 
            // dtpDataSystem
            // 
            this.dtpDataSystem.Location = new System.Drawing.Point(137, 145);
            this.dtpDataSystem.Name = "dtpDataSystem";
            this.dtpDataSystem.Size = new System.Drawing.Size(332, 20);
            this.dtpDataSystem.TabIndex = 60;
            // 
            // dtpDataProgramare
            // 
            this.dtpDataProgramare.Location = new System.Drawing.Point(137, 171);
            this.dtpDataProgramare.Name = "dtpDataProgramare";
            this.dtpDataProgramare.Size = new System.Drawing.Size(332, 20);
            this.dtpDataProgramare.TabIndex = 62;
            // 
            // lblDataProgramare
            // 
            this.lblDataProgramare.AutoSize = true;
            this.lblDataProgramare.Location = new System.Drawing.Point(25, 174);
            this.lblDataProgramare.Name = "lblDataProgramare";
            this.lblDataProgramare.Size = new System.Drawing.Size(90, 13);
            this.lblDataProgramare.TabIndex = 61;
            this.lblDataProgramare.Text = "Data Programare:";
            // 
            // dtpDataFinalizare
            // 
            this.dtpDataFinalizare.Location = new System.Drawing.Point(137, 197);
            this.dtpDataFinalizare.Name = "dtpDataFinalizare";
            this.dtpDataFinalizare.Size = new System.Drawing.Size(332, 20);
            this.dtpDataFinalizare.TabIndex = 64;
            // 
            // lblDataFinalizare
            // 
            this.lblDataFinalizare.AutoSize = true;
            this.lblDataFinalizare.Location = new System.Drawing.Point(25, 200);
            this.lblDataFinalizare.Name = "lblDataFinalizare";
            this.lblDataFinalizare.Size = new System.Drawing.Size(80, 13);
            this.lblDataFinalizare.TabIndex = 63;
            this.lblDataFinalizare.Text = "Data Finalizare:";
            // 
            // txtDescriere
            // 
            this.txtDescriere.Location = new System.Drawing.Point(137, 249);
            this.txtDescriere.MaxLength = 25;
            this.txtDescriere.Name = "txtDescriere";
            this.txtDescriere.Size = new System.Drawing.Size(332, 20);
            this.txtDescriere.TabIndex = 66;
            // 
            // lblDescriere
            // 
            this.lblDescriere.AutoSize = true;
            this.lblDescriere.Location = new System.Drawing.Point(25, 252);
            this.lblDescriere.Name = "lblDescriere";
            this.lblDescriere.Size = new System.Drawing.Size(55, 13);
            this.lblDescriere.TabIndex = 65;
            this.lblDescriere.Text = "Descriere:";
            // 
            // txtValoarePiese
            // 
            this.txtValoarePiese.Enabled = false;
            this.txtValoarePiese.Location = new System.Drawing.Point(137, 275);
            this.txtValoarePiese.MaxLength = 25;
            this.txtValoarePiese.Name = "txtValoarePiese";
            this.txtValoarePiese.Size = new System.Drawing.Size(332, 20);
            this.txtValoarePiese.TabIndex = 68;
            // 
            // lblValoarePiese
            // 
            this.lblValoarePiese.AutoSize = true;
            this.lblValoarePiese.Location = new System.Drawing.Point(25, 278);
            this.lblValoarePiese.Name = "lblValoarePiese";
            this.lblValoarePiese.Size = new System.Drawing.Size(75, 13);
            this.lblValoarePiese.TabIndex = 67;
            this.lblValoarePiese.Text = "Valoare Piese:";
            // 
            // cmbStareComanda
            // 
            this.cmbStareComanda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStareComanda.FormattingEnabled = true;
            this.cmbStareComanda.Items.AddRange(new object[] {
            "InAsteptare",
            "Executata",
            "RefuzataLaExecutie"});
            this.cmbStareComanda.Location = new System.Drawing.Point(137, 119);
            this.cmbStareComanda.Name = "cmbStareComanda";
            this.cmbStareComanda.Size = new System.Drawing.Size(333, 21);
            this.cmbStareComanda.TabIndex = 69;
            // 
            // mtbKmBord
            // 
            this.mtbKmBord.Location = new System.Drawing.Point(137, 223);
            this.mtbKmBord.Mask = "999999999";
            this.mtbKmBord.Name = "mtbKmBord";
            this.mtbKmBord.Size = new System.Drawing.Size(332, 20);
            this.mtbKmBord.TabIndex = 70;
            this.mtbKmBord.ValidatingType = typeof(int);
            // 
            // ComandaAddMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 334);
            this.Controls.Add(this.mtbKmBord);
            this.Controls.Add(this.cmbStareComanda);
            this.Controls.Add(this.txtValoarePiese);
            this.Controls.Add(this.lblValoarePiese);
            this.Controls.Add(this.txtDescriere);
            this.Controls.Add(this.lblDescriere);
            this.Controls.Add(this.dtpDataFinalizare);
            this.Controls.Add(this.lblDataFinalizare);
            this.Controls.Add(this.dtpDataProgramare);
            this.Controls.Add(this.lblDataProgramare);
            this.Controls.Add(this.dtpDataSystem);
            this.Controls.Add(this.lblDataSystem);
            this.Controls.Add(this.cmbClientId);
            this.Controls.Add(this.cmbAutoId);
            this.Controls.Add(this.lblClientId);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddModComanda);
            this.Controls.Add(this.lblComanda);
            this.Controls.Add(this.txtComandaId);
            this.Controls.Add(this.lblKmBord);
            this.Controls.Add(this.lblAutoId);
            this.Controls.Add(this.lblStareComanda);
            this.Controls.Add(this.lblComandaId);
            this.Name = "ComandaAddMod";
            this.Text = "ComandaAddMod";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbClientId;
        private System.Windows.Forms.ComboBox cmbAutoId;
        private System.Windows.Forms.Label lblClientId;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddModComanda;
        private System.Windows.Forms.Label lblComanda;
        private System.Windows.Forms.TextBox txtComandaId;
        private System.Windows.Forms.Label lblKmBord;
        private System.Windows.Forms.Label lblAutoId;
        private System.Windows.Forms.Label lblStareComanda;
        private System.Windows.Forms.Label lblComandaId;
        private System.Windows.Forms.Label lblDataSystem;
        private System.Windows.Forms.DateTimePicker dtpDataSystem;
        private System.Windows.Forms.DateTimePicker dtpDataProgramare;
        private System.Windows.Forms.Label lblDataProgramare;
        private System.Windows.Forms.DateTimePicker dtpDataFinalizare;
        private System.Windows.Forms.Label lblDataFinalizare;
        private System.Windows.Forms.TextBox txtDescriere;
        private System.Windows.Forms.Label lblDescriere;
        private System.Windows.Forms.TextBox txtValoarePiese;
        private System.Windows.Forms.Label lblValoarePiese;
        private System.Windows.Forms.ComboBox cmbStareComanda;
        private System.Windows.Forms.MaskedTextBox mtbKmBord;
    }
}