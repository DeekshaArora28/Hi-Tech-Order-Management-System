using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hi_Tech_Order_Management_System.Validation;
using System.Text.RegularExpressions;

namespace Hi_Tech_Order_Management_System.Validation
{
    public class Validation
    {

     


        public static bool IsValidId(string input, int size)
        {
            if (!(Regex.IsMatch(input, @"^\d{" + size + "}$")))
            {
                return false;
            }
            return true;
        }

        public static bool IsValidName(string input)
        {
            if (input == "")
            {
                return false;
            }

            for (int i = 0; i < input.Length; i++)
            {
                if (!(Char.IsLetter(input[i])) && !(Char.IsWhiteSpace(input[i])))
                {
                    return false;
                }

            }

            return true;

        }

        public static bool IsEmpty(string input)
        {
            if (input == "")
            {
                return true;
            }

            return false;

        }
    }
}
