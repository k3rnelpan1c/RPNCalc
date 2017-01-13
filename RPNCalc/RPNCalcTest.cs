using System;
using NUnit.Framework;

namespace RPNCalc
{
    public class RPNCalcTest
    {
        RPNCalculator rpnCalculatorObj = new RPNCalculator();

        [Test]
        public void TwoValueAdditionStringInput()
        {            
            Assert.AreEqual(8, rpnCalculatorObj.calculate("2,6,+"));
        }

        [Test]
        public void EmptyStringInput()
        {
            try
            {
                rpnCalculatorObj.calculate("");
            }
            catch(Exception ex)
            {
                Assert.Pass(ex.Message);
            }
        }

        [Test]
        public void InputStringWithoutOperator()
        {
            try
            {
                rpnCalculatorObj.calculate("2,6");
            }
            catch (Exception ex)
            {
                Assert.Pass(ex.Message);
            }
        }

        [Test]
        public void ThreeValueAdditionStringInput()
        {
            Assert.AreEqual(11,rpnCalculatorObj.calculate("2,6,3,+,+"));
        }

        [Test]
        public void ThreeValueDeductionStringInput()
        {
            Assert.AreEqual(-1, rpnCalculatorObj.calculate("2,6,3,-,-"));
        }

        [Test]
        public void ThreeValueMultiplicationStringInput()
        {
            Assert.AreEqual(36, rpnCalculatorObj.calculate("2,6,3,*,*"));
        }

        [Test]
        public void ThreeValueAdditionSubtractionStringInput()
        {
            Assert.AreEqual(-7, rpnCalculatorObj.calculate("2,6,3,+,-"));
        }

        [Test]
        public void TwoValueAdditionInvalidStringInput()
        {
            try
            {
                rpnCalculatorObj.calculate("2,@,+");
            }
            catch(Exception ex)
            {
                Assert.Pass("Invalid operand is given",ex.Message);
            }
            
        }
    }
}
