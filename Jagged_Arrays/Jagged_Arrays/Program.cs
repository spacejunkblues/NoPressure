//Marshal Fleck
//Fleckm210@gmail.com
//This is an assignment for a system that uses jagged arrays to make a database
using System;

namespace Jagged_Arrays
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Declaring variables
            char[][] names;
            bool LoopActive;
            ulong HowManyNames;
            ulong i;
            bool IsACharacter;
            char EnterCheck;
            ulong CharIndex;

            //Init variables
            LoopActive = true;
            names = new char[10][];
            HowManyNames = 0;
            i = 0;
            IsACharacter = true;
            EnterCheck = ' ';
            CharIndex = 0;

            while (LoopActive)
            {
                //Introduction to the user
                Console.WriteLine("Hello, this is an assignment for a database that uses jagged arrays.");
                Console.WriteLine("How many names would you like to store?");
                Console.WriteLine("Type the Number of names, then hit enter:");
                HowManyNames = ( Convert.ToUInt64(Console.ReadLine()));
                names = new char[HowManyNames][];

                Console.WriteLine(" ");
                Console.WriteLine(" ");

                while (i <= HowManyNames)
                {
                    while (IsACharacter)
                    {

                        names[i] = new char[HowManyNames];

                        Console.Write(CharIndex + 1);
                        Console.WriteLine(". :");

                        EnterCheck += (Convert.ToChar(Console.Read()));
                        if (EnterCheck != 13)
                        {
                            names[i] = new char[names[i].Length + 1];
                            names[i][CharIndex] = EnterCheck;
                            CharIndex++;
                        }
                        else
                        {
                            IsACharacter = false;
                        }
                            
                        
                    }
                    Console.Write(names[i] [i]);


                    i++;
                }
            }
        }
    }
}
