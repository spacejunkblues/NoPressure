using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace InClass_GameTree
{
    class Board
    {
        public List<Piece> pieces;

        public Board()
        {
            pieces = new List<Piece>();
            Print();

        }

        public void Print()
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine(" | | ");
            Console.WriteLine("-----");
            Console.WriteLine(" | | ");
            Console.WriteLine("-----");
            Console.WriteLine(" | | ");
        }

        public void PlacePiece(int x, int y, char player)
        {
            pieces.Add(new Piece(x, y, player));
        }

        //given a X or an O will return if that player has won
        public bool win(char player)
        {
            

            
            //build the win arrays first

            char[][] winArrays = new char[8][];

            for (int i=0; i< 8;i++)
            {
                //8 arrays, each of size 3
                winArrays[i] = new char[3];
            }

            //load the array with X's and O's
            foreach( var p in pieces)
            {

                //--horzons---------

                //load 1st array
                int index = p.x / 2;
                if (p.y == 0)
                    winArrays[0][index]=p.Appearnace;

                //load 2nd array
                if (p.y == 2)
                    winArrays[1][index] = p.Appearnace;


                //load 3rd array
                if (p.y == 4)
                    winArrays[2][index] = p.Appearnace;



                //------verts-------

                //load 4th array
                index = p.y / 2;
                if (p.x == 0)
                    winArrays[3][index] = p.Appearnace;

                //load 5th array
                if (p.x == 2)
                    winArrays[4][index] = p.Appearnace;


                //load 6th array
                if (p.x == 4)
                    winArrays[5][index] = p.Appearnace;



                //------digonals-------

                //load 7th array
                index = p.x / 2;
                if (p.x == p.y)
                    winArrays[6][index] = p.Appearnace;

                //load 8th array
                index = p.x / 2;
                if (p.x + p.y == 4)
                    winArrays[7][index] = p.Appearnace;
            }





            //check the arrays and see if any of them contain all of the given character
            for(int i =0;i<8;i++)
            {
                bool won = true;
                for(int j=0;j<3;j++)
                {
                    if (winArrays[i][j] != player)
                        won = false;
                }

                //if it stayed true, that means there were 3 in a row!
                if(won)
                    return true;

            }

            return false;


        }

    }
    class Piece
    {
        public int x;
        public int y;
        public char Appearnace;

        public Piece()
        {

        }
        public Piece(int x1, int y1, char player)
        {
            x = x1;
            y = y1;
            Appearnace = player;
            Print();
        }
        public void Print()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(Appearnace);
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            Board brd = new Board();
            int x;
            int y;

            while (true)
            {


                //get input from user
                Console.SetCursorPosition(0, 6);
                Console.WriteLine("x?");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("y?");
                y = Convert.ToInt32(Console.ReadLine());

                //place the piece
                brd.PlacePiece(x, y, 'X');

                //say when won
                Console.SetCursorPosition(0, 11);
                if (brd.win('X'))
                    Console.WriteLine("X WON");
            }


        }
    }
}
