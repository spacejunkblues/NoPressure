using System;

namespace InClassLesson21_IO
{
    class Program
    {
        static void Main(string[] args)
        {
            //write to the screen
            Console.WriteLine("Hello World!");

            //move the cursor
            Console.SetCursorPosition(0, 0);

            //Change a single letter
            Console.Write("F");

            //clear the console
            Console.Clear();

            //You can change the color of the console
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;

            //use clear to write the new color to the entire screen
            Console.Clear();
            Console.WriteLine("Hello World!");

            //Can reset
            Console.ResetColor();
            Console.Clear();

            //get WindowHeight and WindowWidth
            int maxheight =Console.WindowHeight;
            int maxwidth = Console.WindowWidth;

            for (int i = 1; i <= maxheight; i++)
                Console.WriteLine(i);

            //print a '*' in the middle of the console
            Console.SetCursorPosition(maxwidth / 2, maxheight / 2);
            Console.Write("*");

            //Use ReadyKey to move the character. Use var to get the return and figure out how to check for UpArrow


        }
    }
}
