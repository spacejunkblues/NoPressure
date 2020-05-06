using System;

namespace InClassLesson7_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare varaibles for scope example
            int i;
            string text;
            string output;
            int x;

            //init i
            i = 0;
            x = 2;
            text = "i: ";
            output = text + "||";

            output = text + i;

            //it's the same as this
            //output = text = (string)i;



            {
                //int x;
                x = 4;
                i = 1;
            }


            Console.WriteLine("i: " + i);

            //same thing
            Console.Write("x: ");
            Console.WriteLine(x);


            //dowhile loops
            i = 9;
            do
            {
                i++;
            } while (i<5);



            //while loop
            i = 9;
            while(i<5)
            {
                i++;
            }


            //for loop
            //  (init, condition, iteration)
            for(i=0;i<5;i++)
            {

            }

            //looping example
            bool keepLooping = true;

            while(keepLooping)
            {
                //declare varable
                int input;

                //Let user know what's happening
                Console.WriteLine("Just entered the loop again");

                //Get user input
                input = Console.Read();
                Console.Read();
                Console.Read();

                //Test to see if we should stop
                if (input == 104)
                {
                    keepLooping = false;
                }

            }//End while

            int input2 =1;

            if (input2 == 0)
            {

            }

        }//End main
    }
}
