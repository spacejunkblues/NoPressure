//Marshal Fleck
//fleckm210@gmail.com
//this is an assignment for a program that can solve the tower problem
using System;

namespace towerproblem
{
    class MainClass
    {
        //Function that solves the problem using recurence
        //MoveRings will move the number of rings given from StartPeg to TargetPeg
        static void MoveRings(int HowManyRings, char StartPeg, char TargetPeg)
        {
            //
            if (HowManyRings != 1) 
            {
                //move the rings that are on top of the current ring. 
                //Move the rings from StartPeg to open peg.
                //MoveRings(number of rings on top of current, peg the current ring is on, open peg)
                MoveRings(HowManyRings - 1, StartPeg, DetermineOpenPeg(TargetPeg, StartPeg));
            }

            Console.Write("Move ring ");
            Console.Write(HowManyRings);
            Console.Write(" from peg ");
            Console.Write(StartPeg);
            Console.Write(" to peg ");
            Console.Write(TargetPeg);
            Console.WriteLine(".");

            Console.WriteLine("press any key to continue:");
            Console.ReadKey();
            Console.WriteLine();

            if (HowManyRings != 1)
            {                
                //takes all the rings that were moved from up above, and moves them to the target
                //From open peg, to targetpeg
                MoveRings(HowManyRings - 1, DetermineOpenPeg(TargetPeg, StartPeg), TargetPeg);
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

                Console.WriteLine();
                Console.WriteLine();

            //Calling the function that solves the problem
            Console.WriteLine("");
            MoveRings(HowManyRings, 'A', 'B');


        }
    }
}
