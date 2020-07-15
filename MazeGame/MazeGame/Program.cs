using System;

namespace MazeGame
{
    class Player 
    {
        public Vector pos;
        public Maze mz;
        char Apearance;

        public Player()
        {
            Apearance = '*';
            pos = new Vector(Console.WindowWidth / 2, Console.WindowHeight/ 2);
            print();
        }

        public void print() 
        {
            Console.SetCursorPosition(pos.x, pos.y);
            Console.WriteLine(Apearance);
        }

    }

    class MZWall 
    {
    
    }

    class Vector
    {
        public int y;
        public int x;

        public void GetVectPos(ref int x2, ref int y2)
        {
            x2 = x;
            y2 = y;
        }

        public void SetVectPos(Vector Newpos)
        {
            Newpos.GetVectPos(ref x, ref y);
        }

        public Vector(int x1, int y1)
        {
            x = x1;
            y = y1;
        }

        public Vector() 
        {
        
        }
    }

    class Maze 
    {
    
    }

    class MZEnd 
    {
    
    }

    class Program
    {
        static void Main(string[] args)
        {
            //get WindowHeight and WindowWidth
            int maxheight = Console.WindowHeight;
            int maxwidth = Console.WindowWidth;

            //for (int i = 1; i <= maxheight; i++)
            //    Console.WriteLine(i);

            //Console.Clear();

            //print a '*' in the middle of the console
            //Console.SetCursorPosition(maxwidth / 2, maxheight / 2);
            //Console.Write("*");

            //Assigning x and y coordinates to the middle of the screen
            int x = maxwidth / 2;

            int y = maxheight / 2;

            Console.CursorVisible = false;


            //Use ReadyKey to move the character. Use var to get the return and figure out how to check for UpArrow
            while (true)
            {
                //Take key info for movement
                ConsoleKeyInfo i = new ConsoleKeyInfo();
                var noKeyPressedYet = i.Key;
                if (Console.KeyAvailable)
                    i = Console.ReadKey(true);
                Player pl = new Player();
            }
        }
    }

}




