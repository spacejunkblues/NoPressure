using System;
using System.Collections.Generic;

namespace Mdict
{
    class Mdict<T>
    {
        //Value will store the name of the person
        public Mdict<T> value;

        public T[] Ages;
        public T[] FirstNames;
        public T[] LastNames;
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            //keeping the keys for mdict in a list
            List<string> names = new List<string>();

            //Declaring mdict
            Mdict<string> dict = new Mdict<string>();

            //Assigning the data arrays
            dict.FirstNames = new string[2];
            dict.Ages = new string[2];
            dict.LastNames = new string[2];

            //Assigning uncle to the mdict and the list
            names.Add("uncle");
            names.Add("bennet");
            names.Add("number");

            dict.FirstNames[0] = "uncle";
            dict.Ages[0] = "number";
            dict.LastNames[0] = "bennet";

            //Assigning Marshy to the mdict and the list
            names.Add("marshy");
            names.Add("fleck");
            names.Add("13");

            dict.FirstNames[1] = "marshy";
            dict.Ages[1] = "13";
            dict.LastNames[1] = "fleck";

            //Printing to the screen the ge of the first one
            Console.WriteLine(dict.Ages[0]);

            //Printing out all the information to the screen using the list
            for (int i = 0; i < 4; i += 3)
            {
                Console.WriteLine(names.ToArray()[i] + " " + names.ToArray()[i + 1] + " age " + names.ToArray()[i + 2]);
            }
        }
    }
}
