using System;

namespace InClassLesson21_IO
{
    class MazeObject
    {
        public int y;
    }

    class Program
    {
        static void Main(string[] args)
        {
            //var j = Console.ReadKey();



            /*write to the screen
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

            */

            //get WindowHeight and WindowWidth
            int maxheight = Console.WindowHeight;
            int maxwidth = Console.WindowWidth;

            //for (int i = 1; i <= maxheight; i++)
            //    Console.WriteLine(i);

            //Console.Clear();

            //print a '*' in the middle of the console
            Console.SetCursorPosition(maxwidth / 2, maxheight / 2);
            Console.Write("*");

            //Assigning x and y coordinates to the middle of the screen
            int x = maxwidth / 2;
            
            int y = maxheight / 2;

            Console.CursorVisible = false;


            //Use ReadyKey to move the character. Use var to get the return and figure out how to check for UpArrow
            while (true)
            {
                //Take key info for movement
                ConsoleKeyInfo i= new ConsoleKeyInfo();
                var noKeyPressedYet = i.Key;
                if (Console.KeyAvailable)
                     i= Console.ReadKey(true);
               

                //up
                if (y > Console.WindowTop)
                {
                    if (i.Key == ConsoleKey.UpArrow)
                    {
                        Console.SetCursorPosition(x, y);
                        Console.Write((char)32);

                        Console.SetCursorPosition(x, y - 1);

                        y -= 1;

                        Console.Write("*");
                    }
                }

                //down
                if (y < Console.WindowHeight)
                {
                    if (i.Key == ConsoleKey.DownArrow)
                    {
                        Console.SetCursorPosition(x, y);
                        Console.Write((char)32);

                        Console.SetCursorPosition(x, y + 1);

                        y += 1;

                        Console.Write("*");
                    }
                }

                //left
                if (x > Console.WindowLeft)
                {
                    if (i.Key == ConsoleKey.LeftArrow)
                    {
                        Console.SetCursorPosition(x, y);
                        Console.Write((char)32);

                        Console.SetCursorPosition(x - 1, y);

                        x -= 1;

                        Console.Write("*");
                    }
                }

                //right
                if (x < Console.WindowWidth)
                {
                    if (i.Key == ConsoleKey.RightArrow)
                    {
                        Console.SetCursorPosition(x, y);
                        Console.Write((char)32);

                        Console.SetCursorPosition(x + 1, y);

                        x += 1;

                        Console.Write("*");
                    }
                }

                Random m = new Random();

                /*Create maze
                for (int index = 0; index < 200; index++)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.DarkGreen;

                    Console.SetCursorPosition(i1 + m.Next(0, 80), i2 + m.Next(0, 26));
                    Console.Write(m.Next(0, 20));
                }*/

            }

        }
    }
}
