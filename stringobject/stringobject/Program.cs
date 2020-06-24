//This an Assignment for a Char Array simulating a string
using System;

namespace stringobject
{
    //Mstring is a Char Array simulating a string
    class Mstring
    {
        //Created 2 private variables, CharArray, and Size
        char[] CharArray;
        long Size;

        //Three methods for acessing and changing mstring
        //SetString sets CharArray to mstring
        public void SetString(char[]mstring)
        {
            //Assigns CharArray Length to mstring Length
            CharArray = new char[mstring.Length];
            Size = CharArray.Length;

            //Assigns CharArray to mstring using AssignArrays
            AssignArrays(ref CharArray, mstring, mstring.Length);
        }

        //Three methods for acessing and changing mstring
        //SetString sets CharArray to mstring
        public void SetString(string mstring)
        {
            //create a chararray
            char[] placeholder = new char[mstring.Length];

            //convert mstring to char array
            for (int i = 0; i < mstring.Length; i++)
                placeholder[i] = mstring[i];

            //call setstring with that chararray
            SetString(placeholder);
        }

        //GetString returns the CharArray
        public char[] GetString()
        {
            //Copy of CharArray
            char[] clone = new char[CharArray.Length];

            //Assigns copy of CharArray using AssignArrays
            AssignArrays(ref clone, CharArray, Size);

            //Returns a copy of chararray to MainClass
            return clone;
        }

        //AppendString adds 2 char arrays to each other
        public void AppendString(char[]Addition)
        {
            //Created a new char array as a placeholder
            char[] PlaceHolder = new char[CharArray.Length + Addition.Length];

            //Assign PlaceHolder to CharArray using AssignArrays
            AssignArrays(ref PlaceHolder, CharArray, Size);

            //Declares index for Addition
            long index = 0;

            //Assigns Addition to the rest of PlaceHolder
            for (long i = CharArray.Length; i < PlaceHolder.Length; i++)
            {
                //Assigns the rest of PlaceHolder to Addition
                PlaceHolder[i] = Addition[index];

                //Increments Index for Addition
                index++;
            }

            //Creates a new Array the size of PlaceHolder
            CharArray = new char[PlaceHolder.Length];
            Size = CharArray.Length;

            //Assigns CharArray to PlaceHolder using AssignArrays
            AssignArrays(ref CharArray, PlaceHolder, Size);
        }

        //Assign Arrays to Each Other
        //Assumes arrays are same size
        void AssignArrays(ref char[]Array1, char[]Array2, long Index)
        {
            //Assigns one Array to another
            for (long i = 0; i < Index; i++)
            {
                //Assigns Arrays
                Array1[i] = Array2[i];

            }
        }

    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            Mstring name1 = new Mstring();
            Mstring name2 = new Mstring();

            char[] ch = new char[2];
            ch[0] = 'd';

            name1.SetString(ch);
            Console.WriteLine(name1.GetString()[0]);
            ch[0] = 'a';
            ch[1] = 'b';
            name2.SetString(ch);
            Console.WriteLine(name2.GetString()[0]);

            //name2.AppendString('b');
            Console.WriteLine(name2.GetString());

            char[] ch2 = new char[5];

            ch2[0] = 'h';
            ch2[1] = 'e';
            ch2[2] = 'l';
            ch2[3] = 'l';
            ch2[4] = 'o';

            name2.AppendString(ch2);

            string name3 = "uncle";

            Console.WriteLine(name3[0]);

            name2.SetString("Hello");
            Console.WriteLine(name2.GetString());
        }
    }
}
