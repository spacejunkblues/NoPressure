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

		//Assign Arrays to Each Other
		//Assumes arrays are same size
		void AssignArrays(ref char[] Array1, string Array2, long index)
        {
			//Assigns one Array to another
			for (long i = 0; i < index; i++)
			{
				//Assigns Arrays
				Array1[i] = Array2[(int)i];

			}
		}

		//Accepts an Initial Value for CharArray
		public Mstring(char[]InitialValue)
        {
            //Makes sure that both arrays are the same size
			CharArray = new char[InitialValue.Length];

			//Assigns CharArray to InitialValue using AssignArrays
			AssignArrays(ref CharArray, InitialValue, Size);
        }

        //Overloads the Function so that a Initial Value is not Required
		public Mstring()
        {
            //Gives CharArray a Preset size of 10
			CharArray = new char[10];
        }

		//Overloads the Function so that a String can be accepted as an Initial Value
		public Mstring(string InitialValue)
        {
			//Makes sure that both arrays are the same size
			CharArray = new char[InitialValue.Length];

			//Assigns CharArray to InitialValue using AssignArrays
			AssignArrays(ref CharArray, InitialValue, Size);
		}

        //OverLoads the <> Operators to check ascii values to find the greater person
        static public bool operator <(Mstring m1, Mstring m2)
        {
            //PlaceHolds the Ascii values for changing
            int PlaceHolder1 = 0;
            int PlaceHolder2 = 0;

            //Index for Determining length
            long Index = m1.CharArray.Length;

            //Determines longer length
            if (m1.CharArray.Length > m2.CharArray.Length)
            {
                Index = m2.CharArray.Length;
            }
            else
            {
                Index = m1.CharArray.Length;
            }

            //Loops thru the arrays til it can find a winner
            for (long i = 0; i < Index; i++)
            {
                //Assigns the PlaceHolders to the ascii values
                PlaceHolder1 = m1.CharArray[i];
                PlaceHolder2 = m2.CharArray[i];

                //Checks for Upper and lower case
                if (PlaceHolder1 < 91 && PlaceHolder1 > 64)
                {
                    PlaceHolder1 += 32;
                }

                //Finds the greater ascii value
                if (PlaceHolder1 > PlaceHolder2)
                {
                    return true;
                }
            }

            return false;
        }

		//OverLoads the <> Operators to check ascii values to find the greater person
		static public bool operator >(Mstring m1, Mstring m2)
		{
            //PlaceHolds the Ascii values for changing
            int PlaceHolder1 = 0;
            int PlaceHolder2 = 0;

            //Index for Determining length
            long Index = m1.CharArray.Length;

            //Determines longer length
            if(m2.CharArray.Length < m1.CharArray.Length)
            {
                Index = m2.CharArray.Length;
            }
            else
            {
                Index = m1.CharArray.Length;
            }

            //Loops thru the arrays til it can find a winner
            for (long i = 0; i < Index; i++)
            {
                //Assigns the PlaceHolders to the ascii values
                PlaceHolder1 = m2.CharArray[i];
                PlaceHolder2 = m1.CharArray[i];

                //Checks for Upper and lower case
                if (PlaceHolder2 < 91 && PlaceHolder2 > 64)
                {
                    PlaceHolder2 += 32;
                }

                //Finds the greater ascii value
                if (PlaceHolder2 > PlaceHolder1)
                {
                    return true;
                }
            } 

            //if this runs, the statement is false
            return false;
        }

        
	}

	class MainClass
    {
        public static void Main(string[] args)
        {
            Mstring name1 = new Mstring();
            Mstring name2 = new Mstring();

            name1.SetString("a");                                    
            if (name1 > name2)
            {
                Console.WriteLine("Name1 is greater!");
            }
            
            Console.ReadLine();
        }
    }
}
