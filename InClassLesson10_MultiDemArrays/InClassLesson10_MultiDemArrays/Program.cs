using System;

namespace InClassLesson10_MultiDemArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //----------------jagged array-------------------------
            char[][] names = new char[10][];

            //this is an array of 10 names. Each name can have a different length.

            //This line will error out since none of the ten inner arrays have memory allocated
            //names[0][0] = 'U';

            //get memory for the first name
            names[0] = new char[5];

            //now we can assign the sub array
            names[0][0] = 'U';
            names[0][1] = 'n';
            names[0][2] = 'c';
            names[0][3] = 'l';
            names[0][4] = 'e';

            //How does a multi-demisional jagged array print?
            Console.WriteLine(names);

            //How about just the first name?
            Console.WriteLine(names[0]);

            names[1] = new char[7];

            names[1][0] = 'M';
            names[1][1] = 'a';
            names[1][2] = 'r';
            names[1][3] = 's';
            names[1][4] = 'h';
            names[1][5] = 'a';
            names[1][6] = 'l';











            //--------2D array------------------
            int[,] numbers;
            
            numbers = new int[3, 4];

            //2D Array will have each sub array be the same size

            //this new statement allocates the entire array at once

            //How does writeline work with a 2D array?
            Console.WriteLine(numbers);

            //assign a number
            numbers[0, 0] = 1;
            numbers[0, 1] = 2;
            numbers[0, 2] = 3;

            //how to print
            Console.WriteLine(numbers[0,0]);











            //show .length

            //another example of 2-D array
            char[,] TicTacToeBoard = new char[3, 3];
            
            //put a blank character in each spot
            for(int i=0; i<3; i++)
            {
                for(int j=0; j<3; j++)
                {
                    TicTacToeBoard[i, j] = '*';//Put an * to see the blanks
                }
            }

            //put an 'X' in the center
            TicTacToeBoard[1, 1] = 'X';
            TicTacToeBoard[0, 2] = 'O';

            //Print the board
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(TicTacToeBoard[i, j]);
                    Console.Write(' ');
                }
                Console.Write('\n');
            }









            //You can get crazy with the demisions
            int[,,,] x = new int [4,4,5,2];

            //assignment works the same way. This is the first spot
            x[0, 0, 0, 0] = 1;

            //Or set a value anywhere
            x[0, 3, 2, 1] = 5;


        }
    }
}
