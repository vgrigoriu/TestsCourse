using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Core
{
    public class CalculatorEngine
    {
        public double CurrentValue { get; set; }
        public double? Total { get; set; }
        
        public void Add()
        {
            if (!Total.HasValue)
            {
                Total = 0;
            }

            Total += CurrentValue;
        }

        public void Subtruct()
        {
            if (!Total.HasValue)
            {
                Total = 0;
            }
            Total -= CurrentValue;
        }

        public void Multiply()
        {
        }

        public void Divide()
        {
        }


    }
}
