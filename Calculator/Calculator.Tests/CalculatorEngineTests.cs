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
    public class CalculatorEngineTests
    {
        [TestMethod]
        public void GetTotal_Default_Returns0()
        {
            CalculatorEngine engine = new CalculatorEngine();

            var total = engine.GetTotal();

            Assert.AreEqual(0, total);
        }

        [TestMethod]
        public void Set_5_TotalIsAsExpected()
        {
            CalculatorEngine engine = new CalculatorEngine();

            engine.Set(5);
            var total = engine.GetTotal();

            Assert.AreEqual(5, total);
        }

        [TestMethod]
        public void Add_TestAdd()
        {
            CalculatorEngine engine = new CalculatorEngine();
            engine.Set(10);
            engine.Add(5);

            var total = engine.GetTotal();

            Assert.AreEqual(15, total);
        }

        [TestMethod]
        public void Subtract_5From7_TotalIs2()
        {
            CalculatorEngine engine = new CalculatorEngine();
            engine.Set(7);

            engine.Subtract(5);

            Assert.AreEqual(2, engine.GetTotal());
        }

        [TestMethod]
        public void Test_Multiply()
        {
            CalculatorEngine engine = new CalculatorEngine();
            engine.Multiply(6);

            Assert.AreEqual(0, engine.GetTotal());
        }

        [TestMethod]
        public void Test_AnotherMultiply()
        {
            CalculatorEngine engine = new CalculatorEngine();
            engine.Set(20);
            
            engine.Multiply(2);
            
            Assert.AreEqual(40, engine.GetTotal());
        }

        [TestMethod]
        public void Test_Divide()
        {
            CalculatorEngine engine = new CalculatorEngine();
            engine.Set(20);

            engine.Divide(10);
            
            Assert.AreEqual(2, engine.GetTotal());
        }

        [TestMethod]
        public void Divide_ByZero_ThrowsException()
        {
            CalculatorEngine engine = new CalculatorEngine();
            engine.Set(10);

            try
            {
                engine.Divide(0);
            }

            catch(DivideException) 
            {
                Assert.IsTrue(true);
                return;
            }

            Assert.Fail();
        }

        [TestMethod]
        public void test_clear()
        {
            CalculatorEngine engine = new CalculatorEngine();
            engine.Set(114);

            engine.Clear();
            Assert.AreEqual(0, engine.GetTotal());
        }

    }
}
