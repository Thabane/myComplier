﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompileFunctions
{
    public class Functionality
    {
       

        private void readChar(ref int IX, ref string sentence, ref string testChar, ref int inputType)
        {

            testChar = sentence.Substring(IX, 1);
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
                (testChar.CompareTo(",") == 0) |
                (testChar.CompareTo("=") == 0))
            {
                inputType = 5; // delimeter
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
                    inputType = 3; // numeric              
                } // end if compareTo Numeric
                else
                {
                    if ((testChar.CompareTo(" ") == 0)) inputType = 6;
                    else
                        if ((testChar.CompareTo(";") == 0)) inputType = 7;
                    else
                    {
                        inputType = 1; // alpha
                    } // end alpha
                } // end else


            } // end if


        } // end readChar
    }
}
