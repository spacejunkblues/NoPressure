﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace InClass_GameTree
{
    class Board
    {
        public List<Piece> pieces;
        public List<Piece> blanks;

        public Board()
        {
            pieces = new List<Piece>();
            blanks = new List<Piece>();

            //fill the blanks
            for(int x=0;x<=4;x += 2)
            {
                for (int y = 0; y <= 4; y += 2) 
                {
                    blanks.Add(new Piece(x, y,' '));
                }
            }
            Print();

        }

        //Used for fake boards!!!!
        public Board(Board prevboard)
        {
            pieces = new List<Piece>();
            blanks = new List<Piece>();

            //add peices to new baord
            foreach (var p in prevboard.pieces)
            {
                pieces.Add(p);
            }

            //add blanks
            foreach (var p in prevboard.blanks)
            {
                blanks.Add(p);
            }
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

        public void PlacePiece(int x, int y, char player, bool show)
        {
            //save new peice in a variable
            Piece newPiece = new Piece(x, y, player);

            //add the new peice
            pieces.Add(newPiece);


            //search for the x,y coords in blank
            int indexRemoved=-1;
            for(int i=0;i<blanks.Count;i++)
            {
                if (blanks[i] == newPiece)
                {
                    indexRemoved = i;
                    break;
                }
            }

            //remove the found peice
            if (indexRemoved > -1)
                blanks.RemoveAt(indexRemoved);

            if(show)
                newPiece.Print();

        }

        //overload to make it easier to use
        public void PlacePiece(Piece p, bool show)
        {
            PlacePiece(p.x, p.y, p.Appearnace, show);
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
        }
        public void Print()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(Appearnace);
        }

        static public bool operator ==(Piece one, Piece two)
        {
            return one.x == two.x && one.y == two.y;
        }
        static public bool operator !=(Piece one, Piece two)
        {
            return one.x != two.x || one.y != two.y;
        }
    }

    class Program
    {
        //takes the current board state
        //figures out where the best place to place an 'O'
        //returns that info as a piece
        static Piece PlaceEnemnyPiece(Board curbrd, char player)
        {
            foreach(var b in curbrd.blanks)
            {
                Piece tryPiece = new Piece(b.x, b.y, player);

                //make a fake board
                Board newBoard = new Board(curbrd);

                //place a piece onto the fake board
                newBoard.PlacePiece(tryPiece, false);

                //see if it cause me to win
                if(newBoard.win(player))
                {
                    //if placeing the peice wins, then place the peice there!
                    return tryPiece;
                }

                //find out who the other player is
                char otherPlayer;

                if (player == 'O')
                    otherPlayer = 'X';
                else
                    otherPlayer = 'O';

              
                //press to next blank
                Piece otherPlayersWin = PlaceEnemnyPiece(newBoard, otherPlayer);

                //if not null, that means we found a win and we should return it
                if (otherPlayersWin.Appearnace == '?')
                    return tryPiece;

                //Other player will win
                if(otherPlayersWin.Appearnace != '?')
                {
                    tryPiece = new Piece(otherPlayersWin.x, otherPlayersWin.y, player);
                    return tryPiece;
                }

                //if null, keep searching
            }

            //after all the blanks are checked, find the one in which there are no X wins

            return new Piece(0,0,'?');//? means cats game
        }

        static void Main(string[] args)
        {
            Board brd = new Board();
            int x;
            int y;
            char winner = 'N';

            do
            {


                //get input from user
                Console.SetCursorPosition(0, 6);
                Console.WriteLine("x?");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("y?");
                y = Convert.ToInt32(Console.ReadLine());


                //Player places the piece
                brd.PlacePiece(x, y, 'X', true);

                //say if Player won
                if (brd.win('X'))
                {
                    winner = 'X';
                    break;
                }



                //find out where the best place is to place the peice
                Piece e = PlaceEnemnyPiece(brd, 'O');


                //Place the Enemies peice
                brd.PlacePiece(e.x, e.y, e.Appearnace, true);

                //see if Enenmy wins
                if (brd.win('O'))
                {
                    winner = 'O';
                    break;
                }

            }while ( winner !='X'  &&  winner != 'O');



            Console.SetCursorPosition(0, 11);
            Console.WriteLine(winner + " WON");




        }
    }
}
