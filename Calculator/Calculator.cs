using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public BindingList<CalculationResult> db { get; set; }
        public string Value1 { get; set; }
        public Operation Operation { get; set; }
        public string Value2 { get; set; }

        public Calculator()
        {
            InitializeComponent();
            db = new BindingList<CalculationResult>();
            dgwHistory.DataSource = db;
            Operation = Operation.None;
        }

        private void Calculator_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '0':
                    btn0.PerformClick();
                    break;
                case '1':
                    btn1.PerformClick();
                    break;
                case '2':
                    btn2.PerformClick();
                    break;
                case '3':
                    btn3.PerformClick();
                    break;
                case '4':
                    btn4.PerformClick();
                    break;
                case '5':
                    btn5.PerformClick();
                    break;
                case '6':
                    btn6.PerformClick();
                    break;
                case '7':
                    btn7.PerformClick();
                    break;
                case '8':
                    btn8.PerformClick();
                    break;
                case '9':
                    btn9.PerformClick();
                    break;
                case '.':
                    btndot.PerformClick();
                    break;
                case '+':
                    btnAdd.PerformClick();
                    break;
                case '-':
                    btnSubstract.PerformClick();
                    break;
                case '*':
                    btnMultiply.PerformClick();
                    break;
                case '/':
                    btnDivide.PerformClick();
                    break;
                case '=':
                    btnEqual.PerformClick();
                    break;
                default:
                    break;
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            ConstructTheTerms("0");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            ConstructTheTerms("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            ConstructTheTerms("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            ConstructTheTerms("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            ConstructTheTerms("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            ConstructTheTerms("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            ConstructTheTerms("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            ConstructTheTerms("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            ConstructTheTerms("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            ConstructTheTerms("9");
        }

        private void btndot_Click(object sender, EventArgs e)
        {
            ConstructTheTerms(".");
        }

        private void ConstructTheTerms(string value)
        {
            if (Operation == Operation.None)
            {
                if (value != "." || !Value1.Contains("."))
                {
                    Value1 += value;
                    txtCalculatorScreen.Text = Value1;
                }
            }
            else
            {
                if (value != "." || !Value2.Contains("."))
                {
                    Value2 += value;
                    txtCalculatorScreen.Text = $"{Value1} {GetOperationString(Operation)} {Value2}";
                }
            }
        }

        private string GetOperationString(Operation op)
        {
            string result;
            switch (op)
            {
                case Operation.Add:
                    result = "+";
                    break;
                case Operation.Subtract:
                    result = "-";
                    break;
                case Operation.Multiply:
                    result = "*";
                    break;
                case Operation.Divide:
                    result = "/";
                    break;
                default:
                    result = "";
                    break;
            }
            return result;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Value1 != null && Value2 == null)
            {
                Operation = Operation.Add;
                txtCalculatorScreen.Text = $"{Value1} {GetOperationString(Operation)}";
            }
        }

        private void btnSubstract_Click(object sender, EventArgs e)
        {
            if (Value1 != null && Value2 == null)
            {
                Operation = Operation.Subtract;
                txtCalculatorScreen.Text = $"{Value1} {GetOperationString(Operation)}";
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (Value1 != null && Value2 == null)
            {
                Operation = Operation.Multiply;
                txtCalculatorScreen.Text = $"{Value1} {GetOperationString(Operation)}";
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (Value1 != null && Value2 == null)
            {
                Operation = Operation.Divide;
                txtCalculatorScreen.Text = $"{Value1} {GetOperationString(Operation)}";
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (Value1 != null && Operation != Operation.None && Value2 != null)
            {
                double v1, v2;
                double? result = null;

                if (Double.TryParse(Value1, out v1) && Double.TryParse(Value2, out v2))
                {
                    switch (Operation)
                    {
                        case Operation.Add:
                            result = v1 + v2;
                            break;
                        case Operation.Subtract:
                            result = v1 - v2;
                            break;
                        case Operation.Multiply:
                            result = v1 * v2;
                            break;
                        case Operation.Divide:
                            result = v1 / v2;
                            break;
                    }
                    if (result.HasValue)
                    {
                        if (double.IsInfinity(result.Value))
                        {
                            txtCalculatorScreen.Text = "Division by 0 is not allowed.";
                        }
                        else
                        {
                            txtCalculatorScreen.Text = $"{v1.ToString()} {GetOperationString(Operation)} {v2.ToString()} = {result.ToString()}";
                            db.Add(new CalculationResult(v1, Operation, v2, result.Value));
                        }
                        Value1 = null;
                        Value2 = null;
                        Operation = Operation.None;
                    }
                }

            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCalculatorScreen.Text = "";
            Value1 = null;
            Value2 = null;
            Operation = Operation.None;
        }

        private void dgwHistory_SelectionChanged(object sender, EventArgs e)
        {
            if (dgwHistory.SelectedRows.Count == 1)
            {
                txtSumOfAllAboveSelected.Text = dgwHistory.Rows.Cast<DataGridViewRow>().Where(row => row.Index <= dgwHistory.SelectedRows[0].Index).Sum(row => (double)row.Cells[4].Value).ToString();
            }
            
        }
    }
}

