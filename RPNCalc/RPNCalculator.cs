using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace RPNCalc
{
    internal class RPNCalculator
    {
        public RPNCalculator() { }
     
        public double calculate(string expr)
        {
            double firstVal = 0.0, secondVal = 0.0;
            Stack<double> expStack = new Stack<double>();

            string[] expSplit = expr.Split(',');

            if (expr.Length == 0)
            {
                throw new System.Exception("String is empty");
            }

            for (int expSplitCounter = 0; expSplitCounter < expSplit.Length; expSplitCounter++)
            {
                if (expSplit[expSplitCounter].Equals("+") ||
                    expSplit[expSplitCounter].Equals("-") ||
                    expSplit[expSplitCounter].Equals("*") ||
                    expSplit[expSplitCounter].Equals("/") ||
                    expSplit[expSplitCounter].Equals("^") ||
                    expSplit[expSplitCounter].Equals("%") ||
                    expSplit[expSplitCounter].Equals("!"))
                {
                    secondVal = expStack.Pop();
                    firstVal = expStack.Pop();

                    switch (expSplit[expSplitCounter])
                    {
                        case "+":
                            expStack.Push(firstVal + secondVal);
                            break;
                        case "-":
                            expStack.Push(firstVal - secondVal);
                            break;
                        case "*":
                            expStack.Push(firstVal * secondVal);
                            break;
                        case "/":
                            expStack.Push(firstVal / secondVal);
                            break;
                        case "%":
                            expStack.Push(firstVal / 100);
                            break;
                        case "^":
                            expStack.Push(Math.Pow(firstVal, secondVal));
                            break;
                        case "!":
                            expStack.Push(firstVal);
                            break;
                    }
                }
                else
                {
                    int inputValue = int.Parse(expSplit[expSplitCounter]);
                    expStack.Push(inputValue);
                }
            }
            return expStack.Pop();
        }
    }
}