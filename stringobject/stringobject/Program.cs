using System;

namespace stringobject
{
    class Mstring
    {
        //Created 2 private variables, CharArray, and Size
        char[] CharArray;
        long Size;

        //Three methods for acessing and changing mstring
        //SetString sets CharArray to mstring
        public void SetString(char[]mstring)
        {
            CharArray = new char[mstring.Length];
            for (long i = 0; i < mstring.Length; i++)
            {
                CharArray[i] = mstring[i];
            }
        }

        //GetString returns the CharArray
        char[] GetString()
        {
            //Copy of CharArray
            char[] clone = new char[CharArray.Length];

            //Assigns copy of CharArray
            for (long i = 0; i < CharArray.Length; i++)
            {
                clone[i] = CharArray[i];
            }

            return clone;
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            char[] chararrey = new char[10];
            
        }
    }
}
