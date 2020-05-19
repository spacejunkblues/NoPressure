//Marshal Fleck
//Fleckm210@gmail.com
//This is an assignment for a Square Root Generator
using System;

namespace SquareRootGenerator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Declaring variables
            int UserNumber;
            bool MainLoopActivated;
            double i;
            double SquareRoot;

            //Init variables
            UserNumber = 0;
            MainLoopActivated = true;
            i = 0;
            SquareRoot = 0;

            while (MainLoopActivated)
            {

                //Introduction to user
                Console.WriteLine("Hello! this is a Square Root Generator.");
                Console.WriteLine("When i ask, type the number you want to see");
                Console.WriteLine("Ask for a Square Root, then hit enter. :");

                //Getting the Information
                UserNumber = Convert.ToInt32(Console.ReadLine());//This converts an int to a ReadLine function




                for (i = 0; i < UserNumber; i += 0.000000000001)
                {

                    if (i * i == UserNumber)
                    {

                        //Found Square Root!
                        SquareRoot = i;
                        break;


                    }

                }

                Console.Write(SquareRoot);
                Console.Write(" is the Square root of ");
                Console.Write(UserNumber);
                Console.WriteLine(".");

            }

        }
    }

}