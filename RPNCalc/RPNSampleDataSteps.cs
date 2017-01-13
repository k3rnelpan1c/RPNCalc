using NUnit.Framework;
using TechTalk.SpecFlow;
using System;

namespace RPNCalc
{
    [Binding]
    public class RPNCalculationSteps
    {
        RPNCalculator rpnObj = new RPNCalculator();
        string input;
        [Given(@"(.*)")]
        public void Given(string p0)
        {
            //Assert.AreEqual(8, rpnObj.calculate(p0));
            input = p0;
        }
        
        [Then(@"Output will be (.*)")]
        public void ThenOutputWillBe(string p0)
        {
            //ScenarioContext.Current.Pending();
            double temp = Convert.ToDouble(p0);
            Assert.AreEqual(temp, rpnObj.calculate(input));
        }
    }
}
