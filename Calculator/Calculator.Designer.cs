using System.Windows.Forms;

namespace Calculator
{
    partial class Calculator
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
            this.pnlCalculator = new System.Windows.Forms.Panel();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnSubstract = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btndot = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.txtCalculatorScreen = new System.Windows.Forms.TextBox();
            this.dgwHistory = new System.Windows.Forms.DataGridView();
            this.txtSumOfAllAboveSelected = new System.Windows.Forms.TextBox();
            this.lblSumOfAllAboveSelected = new System.Windows.Forms.Label();
            this.btnEqual = new System.Windows.Forms.Button();
            this.pnlCalculator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCalculator
            // 
            this.pnlCalculator.BackColor = System.Drawing.SystemColors.Control;
            this.pnlCalculator.Controls.Add(this.btnEqual);
            this.pnlCalculator.Controls.Add(this.btnDivide);
            this.pnlCalculator.Controls.Add(this.btnMultiply);
            this.pnlCalculator.Controls.Add(this.btnSubstract);
            this.pnlCalculator.Controls.Add(this.btnAdd);
            this.pnlCalculator.Controls.Add(this.btnClear);
            this.pnlCalculator.Controls.Add(this.btndot);
            this.pnlCalculator.Controls.Add(this.btn0);
            this.pnlCalculator.Controls.Add(this.btn9);
            this.pnlCalculator.Controls.Add(this.btn8);
            this.pnlCalculator.Controls.Add(this.btn7);
            this.pnlCalculator.Controls.Add(this.btn6);
            this.pnlCalculator.Controls.Add(this.btn5);
            this.pnlCalculator.Controls.Add(this.btn4);
            this.pnlCalculator.Controls.Add(this.btn3);
            this.pnlCalculator.Controls.Add(this.btn2);
            this.pnlCalculator.Controls.Add(this.btn1);
            this.pnlCalculator.Controls.Add(this.txtCalculatorScreen);
            this.pnlCalculator.Location = new System.Drawing.Point(49, 82);
            this.pnlCalculator.Name = "pnlCalculator";
            this.pnlCalculator.Size = new System.Drawing.Size(427, 359);
            this.pnlCalculator.TabIndex = 0;
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(320, 191);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(75, 23);
            this.btnDivide.TabIndex = 16;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(320, 135);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(75, 23);
            this.btnMultiply.TabIndex = 15;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnSubstract
            // 
            this.btnSubstract.Location = new System.Drawing.Point(320, 79);
            this.btnSubstract.Name = "btnSubstract";
            this.btnSubstract.Size = new System.Drawing.Size(75, 23);
            this.btnSubstract.TabIndex = 14;
            this.btnSubstract.Text = "-";
            this.btnSubstract.UseVisualStyleBackColor = true;
            this.btnSubstract.Click += new System.EventHandler(this.btnSubstract_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(319, 24);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(222, 247);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btndot
            // 
            this.btndot.Location = new System.Drawing.Point(28, 247);
            this.btndot.Name = "btndot";
            this.btndot.Size = new System.Drawing.Size(75, 23);
            this.btndot.TabIndex = 11;
            this.btndot.Text = ".";
            this.btndot.UseVisualStyleBackColor = true;
            this.btndot.Click += new System.EventHandler(this.btndot_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(125, 247);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(75, 23);
            this.btn0.TabIndex = 10;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(222, 191);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(75, 23);
            this.btn9.TabIndex = 9;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(125, 191);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(75, 23);
            this.btn8.TabIndex = 8;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(28, 191);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(75, 23);
            this.btn7.TabIndex = 7;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(222, 135);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(75, 23);
            this.btn6.TabIndex = 6;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(125, 135);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(75, 23);
            this.btn5.TabIndex = 5;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(28, 135);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 23);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(222, 79);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 23);
            this.btn3.TabIndex = 3;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(125, 79);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 23);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(28, 79);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // txtCalculatorScreen
            // 
            this.txtCalculatorScreen.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtCalculatorScreen.Enabled = false;
            this.txtCalculatorScreen.Location = new System.Drawing.Point(28, 24);
            this.txtCalculatorScreen.Name = "txtCalculatorScreen";
            this.txtCalculatorScreen.ReadOnly = true;
            this.txtCalculatorScreen.Size = new System.Drawing.Size(269, 20);
            this.txtCalculatorScreen.TabIndex = 0;
            this.txtCalculatorScreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dgwHistory
            // 
            this.dgwHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwHistory.Location = new System.Drawing.Point(564, 82);
            this.dgwHistory.MultiSelect = false;
            this.dgwHistory.Name = "dgwHistory";
            this.dgwHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwHistory.Size = new System.Drawing.Size(559, 319);
            this.dgwHistory.TabIndex = 1;
            this.dgwHistory.SelectionChanged += new System.EventHandler(this.dgwHistory_SelectionChanged);
            // 
            // txtSumOfAllAboveSelected
            // 
            this.txtSumOfAllAboveSelected.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtSumOfAllAboveSelected.Enabled = false;
            this.txtSumOfAllAboveSelected.Location = new System.Drawing.Point(768, 421);
            this.txtSumOfAllAboveSelected.Name = "txtSumOfAllAboveSelected";
            this.txtSumOfAllAboveSelected.ReadOnly = true;
            this.txtSumOfAllAboveSelected.Size = new System.Drawing.Size(355, 20);
            this.txtSumOfAllAboveSelected.TabIndex = 2;
            // 
            // lblSumOfAllAboveSelected
            // 
            this.lblSumOfAllAboveSelected.AutoSize = true;
            this.lblSumOfAllAboveSelected.Location = new System.Drawing.Point(561, 424);
            this.lblSumOfAllAboveSelected.Name = "lblSumOfAllAboveSelected";
            this.lblSumOfAllAboveSelected.Size = new System.Drawing.Size(201, 13);
            this.lblSumOfAllAboveSelected.TabIndex = 3;
            this.lblSumOfAllAboveSelected.Text = "Sum of all results above  selected record:";
            // 
            // btnEqual
            // 
            this.btnEqual.Location = new System.Drawing.Point(319, 247);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(75, 23);
            this.btnEqual.TabIndex = 17;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1222, 581);
            this.Controls.Add(this.lblSumOfAllAboveSelected);
            this.Controls.Add(this.txtSumOfAllAboveSelected);
            this.Controls.Add(this.dgwHistory);
            this.Controls.Add(this.pnlCalculator);
            this.KeyPreview = true;
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Calculator_KeyPress);
            this.pnlCalculator.ResumeLayout(false);
            this.pnlCalculator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlCalculator;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnSubstract;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btndot;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.TextBox txtCalculatorScreen;
        private System.Windows.Forms.DataGridView dgwHistory;
        private System.Windows.Forms.TextBox txtSumOfAllAboveSelected;
        private System.Windows.Forms.Label lblSumOfAllAboveSelected;
        private Button btnEqual;
    }
}

