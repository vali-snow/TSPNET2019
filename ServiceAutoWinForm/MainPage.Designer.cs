namespace ServiceAutoWinForm
{
    partial class MainPage
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
            this.btnClienti = new System.Windows.Forms.Button();
            this.btnAutoturisme = new System.Windows.Forms.Button();
            this.btnSasiuri = new System.Windows.Forms.Button();
            this.btnComenzi = new System.Windows.Forms.Button();
            this.btnDetaliiComenzi = new System.Windows.Forms.Button();
            this.btnMecanici = new System.Windows.Forms.Button();
            this.btnMateriale = new System.Windows.Forms.Button();
            this.btnImagini = new System.Windows.Forms.Button();
            this.btnOperatii = new System.Windows.Forms.Button();
            this.lblMainMenu = new System.Windows.Forms.Label();
            this.btnMainMenuExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClienti
            // 
            this.btnClienti.Location = new System.Drawing.Point(26, 58);
            this.btnClienti.Name = "btnClienti";
            this.btnClienti.Size = new System.Drawing.Size(181, 23);
            this.btnClienti.TabIndex = 0;
            this.btnClienti.Text = "Clienti";
            this.btnClienti.UseVisualStyleBackColor = true;
            this.btnClienti.Click += new System.EventHandler(this.btnClienti_Click);
            // 
            // btnAutoturisme
            // 
            this.btnAutoturisme.Location = new System.Drawing.Point(26, 87);
            this.btnAutoturisme.Name = "btnAutoturisme";
            this.btnAutoturisme.Size = new System.Drawing.Size(181, 23);
            this.btnAutoturisme.TabIndex = 1;
            this.btnAutoturisme.Text = "Autoturisme";
            this.btnAutoturisme.UseVisualStyleBackColor = true;
            // 
            // btnSasiuri
            // 
            this.btnSasiuri.Location = new System.Drawing.Point(26, 116);
            this.btnSasiuri.Name = "btnSasiuri";
            this.btnSasiuri.Size = new System.Drawing.Size(181, 23);
            this.btnSasiuri.TabIndex = 2;
            this.btnSasiuri.Text = "Sasiuri";
            this.btnSasiuri.UseVisualStyleBackColor = true;
            // 
            // btnComenzi
            // 
            this.btnComenzi.Location = new System.Drawing.Point(26, 145);
            this.btnComenzi.Name = "btnComenzi";
            this.btnComenzi.Size = new System.Drawing.Size(181, 23);
            this.btnComenzi.TabIndex = 3;
            this.btnComenzi.Text = "Comenzi";
            this.btnComenzi.UseVisualStyleBackColor = true;
            // 
            // btnDetaliiComenzi
            // 
            this.btnDetaliiComenzi.Location = new System.Drawing.Point(26, 174);
            this.btnDetaliiComenzi.Name = "btnDetaliiComenzi";
            this.btnDetaliiComenzi.Size = new System.Drawing.Size(181, 23);
            this.btnDetaliiComenzi.TabIndex = 4;
            this.btnDetaliiComenzi.Text = "DetaliiComenzi";
            this.btnDetaliiComenzi.UseVisualStyleBackColor = true;
            // 
            // btnMecanici
            // 
            this.btnMecanici.Location = new System.Drawing.Point(26, 203);
            this.btnMecanici.Name = "btnMecanici";
            this.btnMecanici.Size = new System.Drawing.Size(181, 23);
            this.btnMecanici.TabIndex = 5;
            this.btnMecanici.Text = "Mecanici";
            this.btnMecanici.UseVisualStyleBackColor = true;
            // 
            // btnMateriale
            // 
            this.btnMateriale.Location = new System.Drawing.Point(26, 232);
            this.btnMateriale.Name = "btnMateriale";
            this.btnMateriale.Size = new System.Drawing.Size(181, 23);
            this.btnMateriale.TabIndex = 6;
            this.btnMateriale.Text = "Materiale";
            this.btnMateriale.UseVisualStyleBackColor = true;
            // 
            // btnImagini
            // 
            this.btnImagini.Location = new System.Drawing.Point(26, 261);
            this.btnImagini.Name = "btnImagini";
            this.btnImagini.Size = new System.Drawing.Size(181, 23);
            this.btnImagini.TabIndex = 7;
            this.btnImagini.Text = "Imagini";
            this.btnImagini.UseVisualStyleBackColor = true;
            // 
            // btnOperatii
            // 
            this.btnOperatii.Location = new System.Drawing.Point(26, 290);
            this.btnOperatii.Name = "btnOperatii";
            this.btnOperatii.Size = new System.Drawing.Size(181, 23);
            this.btnOperatii.TabIndex = 8;
            this.btnOperatii.Text = "Operatii";
            this.btnOperatii.UseVisualStyleBackColor = true;
            // 
            // lblMainMenu
            // 
            this.lblMainMenu.AutoSize = true;
            this.lblMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainMenu.Location = new System.Drawing.Point(64, 22);
            this.lblMainMenu.Name = "lblMainMenu";
            this.lblMainMenu.Size = new System.Drawing.Size(105, 24);
            this.lblMainMenu.TabIndex = 9;
            this.lblMainMenu.Text = "Main Menu";
            // 
            // btnMainMenuExit
            // 
            this.btnMainMenuExit.Location = new System.Drawing.Point(26, 319);
            this.btnMainMenuExit.Name = "btnMainMenuExit";
            this.btnMainMenuExit.Size = new System.Drawing.Size(181, 23);
            this.btnMainMenuExit.TabIndex = 10;
            this.btnMainMenuExit.Text = "Exit";
            this.btnMainMenuExit.UseVisualStyleBackColor = true;
            this.btnMainMenuExit.Click += new System.EventHandler(this.btnMainMenuExit_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 369);
            this.Controls.Add(this.btnMainMenuExit);
            this.Controls.Add(this.lblMainMenu);
            this.Controls.Add(this.btnOperatii);
            this.Controls.Add(this.btnImagini);
            this.Controls.Add(this.btnMateriale);
            this.Controls.Add(this.btnMecanici);
            this.Controls.Add(this.btnDetaliiComenzi);
            this.Controls.Add(this.btnComenzi);
            this.Controls.Add(this.btnSasiuri);
            this.Controls.Add(this.btnAutoturisme);
            this.Controls.Add(this.btnClienti);
            this.Name = "MainPage";
            this.Text = "Main Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClienti;
        private System.Windows.Forms.Button btnAutoturisme;
        private System.Windows.Forms.Button btnSasiuri;
        private System.Windows.Forms.Button btnComenzi;
        private System.Windows.Forms.Button btnDetaliiComenzi;
        private System.Windows.Forms.Button btnMecanici;
        private System.Windows.Forms.Button btnMateriale;
        private System.Windows.Forms.Button btnImagini;
        private System.Windows.Forms.Button btnOperatii;
        private System.Windows.Forms.Label lblMainMenu;
        private System.Windows.Forms.Button btnMainMenuExit;
    }
}

