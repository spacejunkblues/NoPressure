using System;
using System.Collections.Generic;
using System.Web;

namespace InClassLesson21_IO
{
    class Program
    {
        static void Main(string[] args)
        {
            var j = Console.ReadKey();

            

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
            int maxheight = Console.WindowHeight;
            int maxwidth = Console.WindowWidth;

            for (int i = 1; i <= maxheight; i++)
                Console.WriteLine(i);

            Console.Clear();

            //print a '*' in the middle of the console
            Console.SetCursorPosition(maxwidth / 2, maxheight / 2);
            Console.Write("*");

            int i1 = maxwidth / 2;
            int i2 = maxheight / 2;


            //Use ReadyKey to move the character. Use var to get the return and figure out how to check for UpArrow
            while (true)
            {

                //up
                ConsoleKeyInfo i = Console.ReadKey();
                if (i2 > 1)
                {
                    if (i.Key == ConsoleKey.UpArrow)
                    {
                        Console.Clear();

                        Console.SetCursorPosition(i1, i2 - 1);

                        i2 -= 1;

                        Console.Write("*");
                    }
                }

                //down
                if (i2 < 19)
                {
                    if (i.Key == ConsoleKey.DownArrow)
                    {
                        Console.Clear();

                        Console.SetCursorPosition(i1, i2 + 1);

                        i2 += 1;

                        Console.Write("*");
                    }
                }

                //left
                if (i1 > 0)
                {
                    if (i.Key == ConsoleKey.LeftArrow)
                    {
                        Console.Clear();

                        Console.SetCursorPosition(i1 - 1, i2);

                        i1 -= 1;

                        Console.Write("*");
                    }
                }

                //right
                if (i1 < 80)
                {
                    if (i.Key == ConsoleKey.RightArrow)
                    {
                        Console.Clear();

                        Console.SetCursorPosition(i1 + 1, i2);

                        i1 += 1;

                        Console.Write("*");
                    }
                }

                Random m = new Random();

                //Create maze
                for (int index = 0; index < 200; index++)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.DarkGreen;

                    Console.SetCursorPosition(i1 + m.Next(0, 80), i2 + m.Next(0, 26));
                    Console.Write(m.Next(0, 20));
                }
            }

        }
    }
}
