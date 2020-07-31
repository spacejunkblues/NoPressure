using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

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

        public void Print2() 
        {
            for (int i = 0; i < pieces.Count; i++) 
            {
                pieces[i].Print();
            }
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

    class WinState
    {
        //This is the piece that caused the winstate
        public Piece p;

        //1 is O wins
        //0 is a tie
        //-1 is X wins
        public int winner;

        public WinState()
        {
            p = new Piece();

        }
        public WinState(Piece aPiece,int winstate)
        {
            p = new Piece();
            p.x = aPiece.x;
            p.y = aPiece.y;
            p.Appearnace = aPiece.Appearnace;

            winner = winstate;
        }
    }

    class Program
    {
        static int GetOtherPlayer(int player)
        {
            return player*-1;
        }
        static char GetOtherPlayer(char player)
        {
            if (player == 'X')
                return 'O';
            else
                return 'X';
        }

        static char PlayerChar(int player)
        {
            if (player == 1)
                return 'O';
            else
                return 'X';
        }

        //player 1 is O
        //player -1 is X
        //returns if the player will win,lose, or tie based on the current players choices at this level
        static WinState TryPiece(Board curbrd, int player)
        {
            int numOfChoices = curbrd.blanks.Count;

            //store the winstates of each peice
            WinState[] winStates = new WinState[numOfChoices];

            //i is the index of the blank
            for(int i=0;i< numOfChoices; i++)
            {
                //try all choices on a new board
                Board newBoard = new Board(curbrd);

                //create a new peice at the blank location for the current player
                Piece newPiece = new Piece();
                newPiece.x = curbrd.blanks[i].x;
                newPiece.y = curbrd.blanks[i].y;
                newPiece.Appearnace = PlayerChar(player);

                //try the current blank
                newBoard.PlacePiece(newPiece, false);

                //see if this results in a victory or lose
                if (newBoard.win('O'))
                {

                    WinState winResult = new WinState(curbrd.blanks[i],1); //gets the blanks location and char loaded into the winstate
                    winResult.p.Appearnace = 'O';//changes the appearnce to show who won
                    winResult.winner = 1;

                    return winResult;

                }
                else if(newBoard.win('X'))
                {
                    WinState winResult = new WinState(curbrd.blanks[i], -1); //gets the blanks location and char loaded into the winstate
                    winResult.p.Appearnace = 'X';//changes the appearnce to show who won
                    winResult.winner = -1;

                    return winResult;

                }

                //deteremine the win state for the current blank
                winStates[i] = TryPiece(newBoard, GetOtherPlayer(player));

                //sets the winstate to the current blank spot
                winStates[i].p.x = curbrd.blanks[i].x;
                winStates[i].p.y = curbrd.blanks[i].y;
                winStates[i].p.Appearnace = PlayerChar(player);

                //do not change winstate.winner
                //If placing an O on the current blank gives the next player a move that wins him the game. Assume this blank spot will win him the game.

            }

            
            //find the last move that will win, lose, tie
            int winIndex=-1;    //each index starts out of range because there may be a no win scenerio
            int loseIndex = -1;
            int tieIndex = -1;

            //find the index's
            for(int i=0;i<numOfChoices;i++)
            {
                if (winStates[i].winner == player)
                    winIndex = i;

                if (winStates[i].winner != player)
                    loseIndex = i;


                if (winStates[i].winner == 0)
                    tieIndex = i;
            }


            //decide which blank to choose
            if (winIndex >= 0)
                return winStates[winIndex]; //choice the winning choice first
            else if (tieIndex >= 0)
                return winStates[tieIndex]; //if there was no winning choice, choose the tie
            else if (loseIndex > -1)
                return winStates[loseIndex]; //if all else fails, take the loss
            else
                return new WinState();//board is full, this is returning a tie since winner defualts to zero


        }


        public static Piece PlaceEasyPiece(Board curbrd, char player) 
        {
            //Create board arrays
            char[][] LoseArrays = new char[8][];

            int[] Length = { 3, 2, 3, 2, 4, 2, 3, 2, 3 };
            int LIndex = 0;

            //Assign arrays set length
            for (int i = 0; i < 8; i++) 
            {
                LoseArrays[i] = new char[3];
            }

            int[][] HValues = new int[3][];
            int[][][] LAIndex = new int[3][][];

            for (int i = 0; i<3; i++) 
            {
                HValues[i] = new int[3];
            }

            for (int row = 0; row < 3; row++) 
            {
                //create boxes
                LAIndex[row] = new int[3][];

                for (int box = 0; box<3; box++) 
                {
                    LAIndex[row][box] = new int[Length[LIndex]];
                    LIndex++;
                    
                    LAIndex[row][box][0] = row;
                    LAIndex[row][box][1] = box + 3;
                }
            }

            LAIndex[0][0][2] = 6;
            LAIndex[0][2][2] = 7;
            LAIndex[1][1][2] = 6;
            LAIndex[1][1][3] = 7;
            LAIndex[2][0][2] = 7;
            LAIndex[2][2][2] = 6;

            //load the array with X's and O's
            foreach (var p in curbrd.pieces)
            {

                //--horzons---------

                //load 1st array
                int index = p.x / 2;
                if (p.y == 0)
                    LoseArrays[0][index] = p.Appearnace;

                //load 2nd array
                if (p.y == 2)
                    LoseArrays[1][index] = p.Appearnace;


                //load 3rd array
                if (p.y == 4)
                    LoseArrays[2][index] = p.Appearnace;



                //------verts-------

                //load 4th array
                index = p.y / 2;
                if (p.x == 0)
                    LoseArrays[3][index] = p.Appearnace;

                //load 5th array
                if (p.x == 2)
                    LoseArrays[4][index] = p.Appearnace;


                //load 6th array
                if (p.x == 4)
                    LoseArrays[5][index] = p.Appearnace;



                //------digonals-------

                //load 7th array
                index = p.x / 2;
                if (p.x == p.y)
                    LoseArrays[6][index] = p.Appearnace;

                //load 8th array
                index = p.x / 2;
                if (p.x + p.y == 4)
                    LoseArrays[7][index] = p.Appearnace;
            }

            //Check with LoseArrays to find hearistic value
            for (int row = 0; row < 3; row++) 
            {
                for (int box = 0; box<3; box++) 
                {
                    for (int i = 0; i<LAIndex[row][box].Length; i++) 
                    {
                        //If found a blank inside losearrays
                        if (LoseArrays[row][box] == 0)
                        {
                            //Check with losearrays with laindex's index's to find x's inside losearrays
                            for (int j = 0; j<3; j++) 
                            {
                                if (LoseArrays[LAIndex[row][box][i]][j] == GetOtherPlayer(player)) 
                                {
                                    HValues[row][box]++;
                                }
                            }
                        }
                        else 
                        {
                            HValues[row][box] = 1000;
                        }
                    }
                } 
            }

            int LWSTV = HValues[0][0];

            //Search for lowest
            for (int row = 0; row<3; row++) 
            {
                for (int box = 0; box<3; box++) 
                {
                    if (HValues[row][box] < LWSTV) 
                    {
                        LWSTV = HValues[row][box];
                    }
                }
            }

            //find and return the lowest with LWSTV
            for (int row = 0; row < 3; row++)
            {
                for (int box = 0; box < 3; box++)
                {
                    if (HValues[row][box] == LWSTV)
                    {
                        return new Piece( box*2, row*2, player);
                    }
                }
            }

            return null;
        }

        static public int HValue(Board BrdState)
        {
            //Create variables
            int xs = 0;
            int os = 0;

            char[][] winArrays = new char[8][];

            for (int i = 0; i<8; i++)
            {
                winArrays[i] = new char[3];
            }

            //Find out how many x's and o's there are
            //load the array with X's and O's
            foreach (var p in BrdState.pieces)
            {

                //--horzons---------

                //load 1st array
                int index = p.x / 2;
                if (p.y == 0)
                    winArrays[0][index] = p.Appearnace;

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

            //Variable for tracking the amount of winnable pieces in this row
            int GPieces = 0;

            //find out the amount of winnable pieces there are for both sides
            //find out the amount of winnable pieces there are for x
            for (int row = 0; row<8; row++)
            {
                for (int box = 0; box<3; box++)
                {
                    if (winArrays[row][box] == 'X')
                    {
                        xs++;
                        GPieces++;
                    }
                    else if (winArrays[row][box] == 'O')
                    {
                        xs -= GPieces;
                    }
                }

                GPieces = 0;
            }

            GPieces = 0;

            //find out the amount of winnable pieces there are for o
            //find out the amount of winnable pieces there are for x
            for (int row = 0; row < 8; row++)
            {
                for (int box = 0; box < 3; box++)
                {
                    if (winArrays[row][box] == 'O')
                    {
                        os++;
                        GPieces++;
                    }
                    else if (winArrays[row][box] == 'X')
                    {
                        os -= GPieces;
                    }
                }

                GPieces = 0;
            }

            //Subtract them from each other
            GPieces = xs - os;

            //Return the final product
            return GPieces;
        }

        static void Main(string[] args)
        {
            Board brd = new Board();
            int x;//user input locaiotns
            int y;
            char winner = 'N';//N for none, other options are X and O

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
                //Hard mode
                char mode = 'M';
                WinState ws = new WinState();

                if (mode == 'H')
                    ws = TryPiece(brd, 1);//1 is player O, and -1 is player X
                else if (mode == 'E')
                    ws.p = PlaceEasyPiece(brd, 'O');//1 is player O, and -1 is player X
                else if (mode == 'M')
                    HValue(brd);


                //Place the Enemies peice
                brd.PlacePiece(ws.p, true);

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
