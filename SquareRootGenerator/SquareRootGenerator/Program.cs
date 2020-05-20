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
            decimal i;
            decimal SquareRoot;
            decimal SRN;
            decimal SRPA;

            //Init variables
            UserNumber = 0;
            MainLoopActivated = true;
            i = 0;
            SquareRoot = 0;
            SRN = 0;
            SRPA = 0;

            while (MainLoopActivated)
            {
                //Reset variables
                UserNumber = 0;
                MainLoopActivated = true;
                i = 0;
                SquareRoot = 0;
                SRN = 0;
                SRPA = 0;

                //Introduction to user
                Console.WriteLine("Hello! this is a Square Root Generator.");
                Console.WriteLine("When i ask, type the number you want to see");
                Console.WriteLine("Ask for a Square Root, then hit enter. :");

                //Getting the Information
                UserNumber = Convert.ToInt32(Console.ReadLine());//This converts an int to a ReadLine function




                for (i = 0; i <= UserNumber; i += (decimal)0.0001)
                {
                    //Console.WriteLine(i);
                   
                    if (i == (decimal)1.4140) 
                    {
                       //Console.WriteLine("Ready.");
                        
                    }
                     
                    if (i * i == UserNumber) 
                    {
                        SquareRoot = i;
                        break;
                    }

                    

                    if ((i * i) < UserNumber) 
                    {
                        SRPA = i * i;

                        SquareRoot = i;
                    }
                    else 
                    {
                        break;
                    }

                }

                Console.Write("Ready.");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.Write((double)SquareRoot);
                Console.Write(" is the Square root of ");
                Console.Write(UserNumber);
                Console.WriteLine(".");

                Console.WriteLine("Press any key to continue:");
                Console.ReadKey();

            }

        }
    }

}