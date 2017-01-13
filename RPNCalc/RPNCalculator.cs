using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace RPNCalc
{
    internal class RPNCalculator
    {
        public RPNCalculator() { }
     
        public int calculate(string expr)
        {
            int firstVal = 0, secondVal = 0;
            Stack<int> expStack = new Stack<int>();
 //           Regex operatorRegEx = new Regex("\d+");

            string[] expSplit = expr.Split(',');

            if (expr.Length == 0)
            {
                throw new System.Exception("String is empty");
            }

            for (int expSplitCounter = 0; expSplitCounter < expSplit.Length; expSplitCounter++)
            {
                if (expSplit[expSplitCounter].Equals("+") ||
                    expSplit[expSplitCounter].Equals("-") ||
                    expSplit[expSplitCounter].Equals("*"))
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