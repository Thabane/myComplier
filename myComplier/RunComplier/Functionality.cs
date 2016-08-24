using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunComplier
{
    public class Functionality
    {       
        internal void readChar(int IX, string sentence)
        {
            string testChar = sentence.Substring(IX, 1);
            IX = IX + 1;

            if ((testChar.CompareTo("|") == 0) |
                (testChar.CompareTo("*") == 0) |
                (testChar.CompareTo("/") == 0) |
                (testChar.CompareTo("+") == 0) |
                (testChar.CompareTo("-") == 0) |
                (testChar.CompareTo("@") == 0) |
                (testChar.CompareTo("#") == 0) |
                (testChar.CompareTo("$") == 0) |
                (testChar.CompareTo("%") == 0) |
                (testChar.CompareTo("^") == 0) |
                (testChar.CompareTo("&") == 0) |
                (testChar.CompareTo("(") == 0) |
                (testChar.CompareTo(")") == 0) |
                (testChar.CompareTo("!") == 0) |
                (testChar.CompareTo(",") == 0) |
                (testChar.CompareTo("=") == 0))
            {
                GlobalStore.FunctionType = 5;// delimeter
            }
            else
            {
                if ((testChar.CompareTo("0") == 0) |
                    (testChar.CompareTo("1") == 0) |
                    (testChar.CompareTo("2") == 0) |
                    (testChar.CompareTo("3") == 0) |
                    (testChar.CompareTo("4") == 0) |
                    (testChar.CompareTo("5") == 0) |
                    (testChar.CompareTo("6") == 0) |
                    (testChar.CompareTo("7") == 0) |
                    (testChar.CompareTo("8") == 0) |
                    (testChar.CompareTo("9") == 0))
                {
                    GlobalStore.FunctionType = 3; // numeric              
                }
                else
                {
                    if ((testChar.CompareTo(" ") == 0)) GlobalStore.FunctionType = 6;
                    else
                        if ((testChar.CompareTo(";") == 0)) GlobalStore.FunctionType = 7;
                    else
                    {
                        GlobalStore.FunctionType = 1;
                    }
                }
            }
        }

        internal void PrintResponse(string text)
        {
            Console.WriteLine(text);
        }

        internal string ReadInput()
        {
            return Console.ReadLine().ToString();
        }

        internal void convertCharToInt(string alpha)
        {
            string[] alphaVal = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            int[] numVal = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26 };
            int IX = 0;

            for (int x = 0; x < 26; x++)
            {
                if (alpha == alphaVal[x])
                {
                    IX = x;
                    x = 27;
                }
                 GlobalStore.CharIntValue = numVal[IX];
            }
        }

        public int Adding(int input1, int input2)
        {
            return input1 + input2;
        }

        public int Subtract(int input1, int input2)
        {
            return input1 - input2;
        }
    }
}