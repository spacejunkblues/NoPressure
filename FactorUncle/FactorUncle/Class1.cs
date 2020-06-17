using System;
using System.Collections.Generic;
using System.Text;

namespace FactorUncle
{
    class Readit
    {
        static char[] CharArray;
        static char[] ReadLineR(int index)
        {
            int result = Console.Read();

            if (result == 10)
            {
                CharArray = new char[index - 1];
            }
            else
            {
                ReadLineR(index + 1);
                if (result != 13)
                    CharArray[index] = (char)result;
            }
            return CharArray;
        }

        static public char[] ReadLine()
        {
            return ReadLineR(0);
        }
    }
}
