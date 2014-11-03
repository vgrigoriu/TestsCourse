using Calculator.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Tests
{
    

    [TestClass]
    public class MemoryHandlerTests
    {

        [TestMethod]
        public void Store_GetTotalIsCalled()
        {
            CalculatorEngineDummy calculator = new CalculatorEngineDummy();
            MemoryReplacement memory = new MemoryReplacement();
            
            var handler = new MemoryHandler(calculator, memory);

            handler.Store();

            Assert.IsTrue(calculator.GetTotalCalled, "GetTotal from CalculatorEngine wasn't called");
        }

        [TestMethod]
        public void Store_StoreIsCalled()
        {
            CalculatorEngine calculator = new CalculatorEngine();
            MemoryReplacement memory = new MemoryReplacement();
            calculator.Set(5);

            var handler = new MemoryHandler(calculator, memory);

            handler.Store();

            Assert.IsTrue(memory.StoreCalled, "Store wasn't called");
            Assert.AreEqual(memory.LastStoreArgument, 5);
        }

        [TestMethod]
        public void Retrieve_RetrieveIsCalled()
        {
            CalculatorEngine calculator = new CalculatorEngine();
            MemoryReplacement memory = new MemoryReplacement();

            var handler = new MemoryHandler(calculator, memory);

            handler.Retrieve();

            Assert.IsTrue(memory.RetrieveCalled);
        }

        [TestMethod]
        public void Retrieve_ValueIsFed()
        {
            CalculatorEngine calculator = new CalculatorEngine();
            MemoryReplacement memory = new MemoryReplacement();
            memory.StoredValue = 6;
            var handler = new MemoryHandler(calculator, memory);

            handler.Retrieve();

            var actualTotal = calculator.GetTotal();
            Assert.AreEqual(6, actualTotal);
        }
        [TestMethod]
        public void Add_value()
        {
            CalculatorEngine calculator = new CalculatorEngine();
            MemoryReplacement memory = new MemoryReplacement();
            memory.StoredValue = 7;
            calculator.Set(9);
            var handler = new MemoryHandler(calculator, memory);

            handler.Add();

            Assert.AreEqual(16, memory.LastStoreArgument);
        }

        [TestMethod]
        public void Subtract_test()
        {
            CalculatorEngineDummy calculator = new CalculatorEngineDummy();
            MemoryReplacement memory = new MemoryReplacement();

            var handler = new MemoryHandler(calculator, memory);
            handler.Subtract();

            Assert.IsTrue(calculator.GetTotalCalled);
        }
        [TestMethod]
        public void Substract_RetriveIsCalled()
        {
            CalculatorEngineDummy calculator = new CalculatorEngineDummy();
            MemoryReplacement memory = new MemoryReplacement();
            
            var handler = new MemoryHandler(calculator, memory);
            handler.Subtract();
            Assert.IsTrue(memory.RetrieveCalled);
        }
        [TestMethod]
        public void Substract_StoreIsCalled()
        {
            CalculatorEngineDummy calculator = new CalculatorEngineDummy();
            MemoryReplacement memory = new MemoryReplacement();
            var handler = new MemoryHandler(calculator, memory);
            handler.Subtract();
            Assert.IsTrue(memory.StoreCalled);
        }

    }
}
