using System;
using System.Collections.Generic;
using System.IO;

namespace MazeGame
{
    class UniFeatures 
    {
        public Vector pos = new Vector();

        public char Apearance;

        public void Print() 
        {
            Console.SetCursorPosition(pos.x, pos.y);
            Console.Write(Apearance);
        }

        public void Clear() 
        {
            Console.SetCursorPosition(pos.x, pos.y);
            Console.Write(" ");
        }
    }

    class Player : UniFeatures
    {
        //Create maze for checking walls
        public Maze mz;

        //Create maze end to check for end
        MZEnd end;

        //Constructor for setting variables and printing player
        public Player()
        {
            Apearance = '*';
            pos = new Vector(1, 1);
            Print();
        }


        public void Move(ConsoleKeyInfo Direction, int HowFar)
        {
            Print();

            //determine which way to move
            int x1 = 0;
            int y1 = 0;

            if (Direction.Key == ConsoleKey.UpArrow)
            {
                y1 = HowFar * -1;
            }
            else if (Direction.Key == ConsoleKey.DownArrow)
            {
                y1 = HowFar;
            }
            else if (Direction.Key == ConsoleKey.RightArrow)
            {
                x1 = HowFar;
            }
            else if (Direction.Key == ConsoleKey.LeftArrow)
            {
                x1 = HowFar * -1;
            }

            //get MovedPos
            //Check for how far and what direction we move to find MovedPos
            Vector MovedPos = new Vector(pos.x + x1, pos.y + y1);

            foreach (MZWall wall in mz.MzList)
            {
                if (MovedPos == wall.pos)
                {
                    return;
                }
            }

            try
            {
                //Stress test
                Console.SetCursorPosition(MovedPos.x, MovedPos.y);

                Clear();

                //move the player
                pos.SetVectPos(MovedPos);

                Print();
            }
            catch
            {

            }

            if (end != null)
            {
                if (end.pos == pos)
                {
                    Console.Write("You Have Won!!");
                }
            }

        }

        public void SetMazePointer(Maze maz)
        {
            mz = maz;
        }

        public void SetEndPointer(MZEnd mzend)
        {
            end = mzend;
        }
    }

    //MZwall is to check for movement collisions within maze
    class MZWall:UniFeatures 
    {
        public MZWall(int x, int y, char Apear) 
        {
            pos.x = x;
            pos.y = y;
            Apearance = Apear;

            Print();
        }
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

        public static bool operator ==(Vector v1, Vector v2) 
        {
            return v1.x == v2.x && v1.y == v2.y;
        }

        public static bool operator !=(Vector v1, Vector v2) 
        {
            return v1.x != v2.x || v1.y != v2.y;
        }
    }

    //Maze will control the maze walls with a list*************
    class Maze 
    {
        //List for controlling maze walls
        public List<MZWall> MzList = new List<MZWall>();

        //Created CreateMaze method for creating maze from .txt file
        public void CreateMaze()
        {
            string[] Mazetxt;

            bool IfError;

            try
            {
                Mazetxt = File.ReadAllLines(@"Maze.txt");
                IfError = false;
            }
            catch
            {
                Mazetxt = File.ReadAllLines(@"Maze.txt");
                IfError = true;
            }

            if (!IfError)
            {
                for (int i = 0; i < File.ReadAllLines(@"Maze.txt").Length; i++)
                {
                    //Create objects for all the walls
                    for (int j = 0; j < Mazetxt[i].Length; j++)
                    {
                        if (Mazetxt[i][j] != (char)32)
                        {
                            MZWall wl = new MZWall(j, i, Mazetxt[i][j]);
                            MzList.Add(wl);
                        }
                    }
                }
            }

            if (IfError)
            {
                for (int i = 0; i < File.ReadAllLines(@"Maze.txt").Length; i++)
                {
                    //Create objects for all the walls
                    for (int j = 0; j < Mazetxt[i].Length; j++)
                    {
                        if (Mazetxt[i][j] != (char)32)
                        {
                            MZWall wl = new MZWall(j, i, Mazetxt[i][j]);
                            MzList.Add(wl);
                        }
                    }

                }
            }
        }

        //Created PrintMaze for printing the entire maze to the screen

    }

    class MZEnd:UniFeatures //***********************
    {
        //Created IfWon for determining if the player has won

        public MZEnd(char apear, int x, int y)
        {
            Apearance = apear;
            pos.x = x;
            pos.y = y;
            Print();
        }
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

            MZEnd end = new MZEnd('€', 40, 20);

            //Create Maze Object
            Maze mz = new Maze();
            pl.SetMazePointer(mz);
            mz.CreateMaze();
            end.Print();
            pl.SetEndPointer(end);

            //Use ReadyKey to move the character. Use var to get the return and figure out how to check for UpArrow
            while (true)
            {
                //Creare variable to store key information
                ConsoleKeyInfo i = new ConsoleKeyInfo();
                var noKeyPressedYet = i.Key;
                end.Print();

                //Take info from console if a key is available in the buffer
                if (Console.KeyAvailable)
                {
                    i = Console.ReadKey(true);
                    pl.Move(i, 1);
                }
                
            }
        }
    }

}




