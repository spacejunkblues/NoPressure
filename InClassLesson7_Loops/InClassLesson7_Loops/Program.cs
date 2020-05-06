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


            bool keepLooping = true;

            while(keepLooping)
            {
                Console.WriteLine("Just entered the loop again");
                int input;
                input = Console.Read();
                Console.Read();
                Console.Read();

                if (input == 104)
                {
                    keepLooping = false;
                }

            }

        }
    }
}
