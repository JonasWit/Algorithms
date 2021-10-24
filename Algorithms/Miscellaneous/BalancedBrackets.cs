using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.Miscellaneous
{
    public class BalancedBrackets
    {
        public static readonly char[] OpeningBrackets = new char[] { '(', '[', '{' };
        public static readonly char[] ClosingBrackets = new char[] { ')', ']', '}' };

        public static bool IsMatchingPair(char character1, char character2)
        {
            if (character1 == '(' && character2 == ')')
                return true;
            else if (character1 == '{' && character2 == '}')
                return true;
            else if (character1 == '[' && character2 == ']')
                return true;
            else
                return false;
        }

        // Return true if expression has balanced
        // Brackets
        public static bool AreBracketsBalanced(char[] exp)
        {
            var charStack = new Stack<char>();

            for (int charPosition = 0; charPosition < exp.Length; charPosition++)
            {
                if (OpeningBrackets.Any(c => c.Equals(exp[charPosition]))) charStack.Push(exp[charPosition]);
                if (ClosingBrackets.Any(c => c.Equals(exp[charPosition])))
                {
                    if (charStack.Count == 0) return false;
                    else if (!IsMatchingPair(charStack.Pop(), exp[charPosition])) return false;
                }
            }

            if (charStack.Count == 0) return true;
            else return false;
        }
    }
}
