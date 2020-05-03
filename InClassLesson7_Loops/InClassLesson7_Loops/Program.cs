using System;

namespace InClassLesson7_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare varaibles for scope example
            int i;
            int[] numbers = { 0,0,0};

            i = 0;

           
            {
                int x;
                x = 4;
                i = 1;
            }


            Console.WriteLine("i: " +i);
        }
    }
}
