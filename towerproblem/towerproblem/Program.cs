//Marshal Fleck
//fleckm210@gmail.com
//this is an assignment for a program that can solve the tower problem
using System;

namespace towerproblem
{
    class MainClass
    {
        //Function that solves the problem using recurence
        static void MoveRings(int HowManyRings, char StartPeg, char TargetPeg)
        {
            //
            if (HowManyRings != 1) 
            {
                MoveRings(HowManyRings - 1, StartPeg, DetermineOpenPeg(TargetPeg, StartPeg));
            }

            Console.Write("Move ring ");
            Console.Write(HowManyRings);
            Console.Write(" from peg ");
            Console.Write(StartPeg);
            Console.Write(" to peg ");
            Console.Write(TargetPeg);
            Console.WriteLine(".");

            if (HowManyRings != 1)
            {
                TargetPeg++;
                MoveRings(HowManyRings - 1, TargetPeg, DetermineOpenPeg(TargetPeg, StartPeg));
            }
        }

        static char DetermineOpenPeg(char peg1, char peg2) 
        {

            char OpenPeg = ' ';

            if (peg1 == 'A' && peg2 == 'B') 
            {
                OpenPeg = 'C';
            }
            else if (peg1 == 'B' && peg2 == 'A') 
            {
                OpenPeg = 'C';
            }
            else if(peg1 == 'C' && peg2 == 'B') 
            {
                OpenPeg = 'A';
            }
            else if (peg1 == 'B' && peg2 == 'C')
            {
                OpenPeg = 'A';
            }
            else if (peg1 == 'C' && peg2 == 'A')
            {
                OpenPeg = 'B';
            }
            else if (peg1 == 'A' && peg2 == 'C')
            {
                OpenPeg = 'B';
            }

            return OpenPeg;

        }

        public static void Main(string[] args)
        {
            //Declaring variables
            int HowManyRings = 1;
            bool LoopActive = true;
          

           

                //It will run while the user has not typed a number sucessfully
                while (LoopActive)
                {
                    Console.WriteLine("How many rings are there?");
                    try
                    {
                        HowManyRings = Convert.ToInt32(Console.ReadLine());
                        LoopActive = false;
                    }
                    catch
                    {
                        Console.WriteLine("Sorry, you have to type a number.");
                    }
                }

            //Calling the function that solves the problem
            MoveRings(HowManyRings, 'A', 'B');


        }
    }
}
