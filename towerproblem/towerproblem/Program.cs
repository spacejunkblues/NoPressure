//Marshal Fleck
//fleckm210@gmail.com
//this is an assignment for a program that can solve the tower problem
using System;

namespace towerproblem
{
    class MainClass
    {
        //Function that solves the problem using recurence
        static void towersolution(int HowManyRings)
        {
            //While the program has not given it self a -1
            if (HowManyRings != -1)
            {
                string[] pegs = new string[3];
                pegs[0] = "A";
                pegs[1] = "B";
                pegs[2] = "C";
                int pegindex = 1;
                int[] pegsequence = new int [4];

                pegsequence[0] = 1;
                pegsequence[1] = 2;
                pegsequence[2] = 1;

                //will run the amount of rings there are to solve
                for (int i = 0; i <= HowManyRings; i++)
                {
                    if (pegindex == 3)
                    {
                        pegindex = 0;
                    }

                    //Printing the answer to the screen
                    Console.Write("Move ring ");
                    Console.Write(pegsequence[i]);
                    Console.Write(" to peg ");
                    Console.Write(pegs[pegsequence[i]]);
                    Console.WriteLine(".");
                    pegindex++;
                }
            }

            //will exit the function if the program gives it self a -1
            else
            {
                return;
            }

            //Recalls the same function
            towersolution(HowManyRings - 1);
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
            towersolution(HowManyRings - 1);
        }
    }
}
