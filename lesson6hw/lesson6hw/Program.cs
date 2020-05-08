//Marshal Fleck
//Fleckm210@gmail.com
//This is an assignment for an advanced calculator
using System;

namespace lesson6hw
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Declaring variables
            int IntHowManyNumbers1;
            int IntHowManyNumbers2;
            int LoopFlag;
            int LoopNumber2;
            int mathnumber1;
            int mathnumber2;
            int MathAdditionAnswer;
            int MathMultiplicationAnswer;
            bool bl;
            string IfUserWantsToTryAgain;

            //Init variables
            IntHowManyNumbers1 = 0;
            IntHowManyNumbers2 = 0;
            LoopFlag = 0;
            LoopNumber2 = 0;
            mathnumber1 = 0;
            mathnumber2 = 0;
            MathAdditionAnswer = 0;
            MathMultiplicationAnswer = 0;
            bl = true;
            IfUserWantsToTryAgain = "";

            while (bl == true)
            {
                //Introduction to the user
                Console.WriteLine("This is a calculator. I will ask how");
                Console.WriteLine("how many numbers will you want to be Added and ");
                Console.WriteLine("Multiplied. How many numbers? hit enter when you are done. ");
                Console.WriteLine("And make sure if it is a singular number, put a ");
                Console.WriteLine("0 before it. :) Thank you!! :");

                //Collecting the amount of numbers that are going to be calculated
                IntHowManyNumbers1 = Console.Read();
                IntHowManyNumbers2 = Console.Read();
                Console.Read();
                Console.Read();

                //Compiling input data
                IntHowManyNumbers2  = (IntHowManyNumbers2 - 48) + (IntHowManyNumbers1 - 48) * 10;
                LoopNumber2 = IntHowManyNumbers2;

                //Calculating loop
                /*while (LoopFlag != LoopNumber2)
                {
                    //Getting the first number
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.WriteLine("First number, then enter. do the first number, then enter.");
                    Console.WriteLine("And so on and so forth. :");
                    mathnumber1 = (mathnumber1 * 10) + Console.Read();
                    Console.Read();
                    Console.Read();
                    mathnumber1 = mathnumber1 - 48;
                    

                    //Getting the second number
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.WriteLine("First number, then enter. do the first number, then enter.");
                    Console.WriteLine("And so on and so forth. :");
                    mathnumber2 = (mathnumber2 * 10) + Console.Read();
                    Console.Read();
                    Console.Read();
                    mathnumber2 = mathnumber2 - 48;

                    LoopFlag = LoopFlag + 1;
                }*/


                LoopFlag = 0;
                MathAdditionAnswer = 0;
                MathMultiplicationAnswer = 1;
                //Calculating loop
                while (LoopFlag != LoopNumber2)
                {
                    int digit1;
                    int digit2;

                    //Getting the first number
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.Write(LoopFlag + 1);
                    Console.WriteLine(": number, then enter. do the first number, then enter.");
                    Console.WriteLine("And so on and so forth. :");

                    digit1 =  Console.Read();   //get first digit so, the digit 1 in "10"
                    digit2 = Console.Read();    //so, the digit 0 in "10"
                    Console.Read();
                    Console.Read();

                    mathnumber1 = ((digit1 -48) * 10) + (digit2 -48); //take the 1, times ten add it to zero

                    //mathnumber1 is now the first number to add


                    //take the math number and add it to our total
                    MathAdditionAnswer += mathnumber1;


                    //take the math number and add it to our total
                    MathMultiplicationAnswer *= mathnumber1;

                    LoopFlag += 1;
                }


                //Clearing the buffer
                Console.WriteLine(" ");
                Console.WriteLine(" ");

                //Calculating the numbers
               // MathAdditionAnswer = mathnumber1 + mathnumber2;
                //MathMultiplicationAnswer = mathnumber1 * mathnumber2;

                //Giving the calculated numbers
                Console.WriteLine("Multiplication answer:");
                Console.WriteLine(MathMultiplicationAnswer);
                Console.WriteLine("Addition answer:");
                Console.WriteLine(MathAdditionAnswer);

                //Clearing the buffer
                Console.WriteLine(" ");
                Console.WriteLine(" ");

                //Asking if the user wants to try again
                Console.WriteLine("Would you like to try again? (lower case yes, to try again or no)");
                Console.WriteLine("to end the program");
                IfUserWantsToTryAgain = Console.ReadLine();
                bl = false;
                if (IfUserWantsToTryAgain == "yes")
                {
                    bl = true;
                }
                

            }
        }

    }

}
