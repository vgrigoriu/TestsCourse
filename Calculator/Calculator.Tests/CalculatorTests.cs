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
    public class CalculatorTests
    {
        private const double DoubleDelta = 0.000001;

        [TestMethod]
        //1.Incearca sa strici codul astfel incat sa pice testul
        public void Add_OneTimes_TotalIsEqualWIthCurrentValue()
        {
            CalculatorEngine calculator = new CalculatorEngine();
            calculator.CurrentValue = 5;

            calculator.Add();

            Assert.AreEqual(5, calculator.Total);
        }

        [TestMethod]
        //2.Adauga testul asta pentru a fi sigur ca trece testul
        public void Add_TwoTimes_CurrentValueAreAddedToTotal()
        {
            CalculatorEngine calculator = new CalculatorEngine();
            calculator.CurrentValue = 5;

            calculator.Add();
            calculator.Add();

            Assert.AreEqual(10, calculator.Total);
        }

        [TestMethod]
        public void Subtract_TwoTimes_CurrentValueIsSubtractedTwice()
        {
            CalculatorEngine calculator = new CalculatorEngine();
            calculator.Total = 45;

            calculator.CurrentValue = 8;
            calculator.Subtruct();
            calculator.Subtruct();

            Assert.AreEqual(29, calculator.Total);
        }

    }
}
