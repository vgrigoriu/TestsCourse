using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Core
{
    public class MemoryHandler
    {
        private CalculatorEngine engine;
        private IMemory memory;

        public MemoryHandler(CalculatorEngine engine, IMemory memory)
        {
            this.engine = engine;
            this.memory = memory;
        }

        public void Add()
        {
            var total = engine.GetTotal();
            var totalm = memory.Retrieve();
            var totalt = total + totalm;
            memory.Store(totalt);
        }

        public void Subtract()
        {
            engine.GetTotal();
            memory.Retrieve();
        }

        public void Store()
        {
            var total = engine.GetTotal();
            memory.Store(total);            
        }

        public void Clear()
        {
        }

        public void Retrieve()
        {
            var storedValue = memory.Retrieve();
            engine.Set(storedValue);
        }
    }
}
