using System;
using System.Collections.Generic;

namespace MazeGame
{
    class Player 
    {
        //Create vector for movement
        public Vector pos;

        //Create maze for checking walls
        public Maze mz;

        //Create char for printing to the screen
        char Apearance;

        //Constructor for setting variables and printing player
        public Player()
        {
            Apearance = '*';
            pos = new Vector(Console.WindowWidth / 2, Console.WindowHeight/ 2);
            print();
        }

        //Print for printing player to the screen
        public void print() 
        {
            Console.SetCursorPosition(pos.x, pos.y);
            Console.WriteLine(Apearance);
        }

    }

    //MZwall is to check for movement collisions within maze
    class MZWall 
    {
    
    }

    //Vector is for setting and getting position inside screen
    class Vector
    {
        //x and y vectors for position on screen
        public int y;
        public int x;

        //Method for getting x and y coodinates
        public void GetVectPos(ref int x2, ref int y2)
        {
            //Assigning referenced coordinates to x and y coordinates of the vector
            x2 = x;
            y2 = y;
        }

        //Method that sets this vector to NewPos
        public void SetVectPos(Vector Newpos)
        {
            Newpos.GetVectPos(ref x, ref y);
        }

        //Constructor for setting coordinates when creating vector
        public Vector(int x1, int y1)
        {
            x = x1;
            y = y1;
        }

        //Constructor so you don't have to set the coordinates when creating vector
        public Vector() 
        {
        
        }
    }

    //Maze will control the maze walls with a list
    class Maze 
    {
        //List for controlling maze walls
        List<MZWall> MzList = new List<MZWall>();
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

            //Create Player Object
            Player pl = new Player();

            //Create Maze Object
            Maze mz = new Maze();

            //Use ReadyKey to move the character. Use var to get the return and figure out how to check for UpArrow
            while (true)
            {
                //Creare variable to store key information
                ConsoleKeyInfo i = new ConsoleKeyInfo();
                var noKeyPressedYet = i.Key;

                //Take info from console if a key is available in the buffer
                if (Console.KeyAvailable) 
                    i = Console.ReadKey(true);
                
            }
        }
    }

}




