using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public enum Operation
    {
        None,
        Add,
        Subtract,
        Multiply,
        Divide
    }

    public class CalculationResult
    {
        public double Value1 { get; set; }
        public Operation Operation { get; set; }
        public double Value2 { get; set; }
        public string Equal { get; private set; }
        public double Result { get; set; }

        public CalculationResult(double v1, Operation op, double v2, double r)
        {
            Value1 = v1;
            Value2 = v2;
            Operation = op;
            Equal = "=";
            Result = r;
        }
    }
}
