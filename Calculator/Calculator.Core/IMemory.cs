using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Core
{
    public interface IMemory
    {
         void Store(double value);
         void Clear();
         double Retrieve();
    }
}
