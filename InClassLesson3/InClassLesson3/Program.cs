using System;

namespace InClassLesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare varaible to capture users input
            int userInput;
            int userInput2;
            string stringUserInput;

            //Ask the user for input
            Console.WriteLine("Type Something:");

            //Get the actually input
            //Read returns an int
            //a single int by the way. If you type more characters you may be surprised.
            userInput = Console.Read();

            //Testing the way Read works
            Console.WriteLine("Type Something else:");
            userInput2 = Console.Read();
            userInput2 = Console.Read();
            userInput2 = Console.Read();
            userInput2 = Console.Read();
            userInput2 = Console.Read();
            userInput2 = Console.Read();

            //Output whatever the user inputted
            Console.WriteLine((char)userInput);




            //Ask the user for input
            Console.WriteLine("Type Something for Readline:");

            //Next is the Readline
            stringUserInput = Console.ReadLine();

            //Output resulsts of the readline
            Console.WriteLine(stringUserInput);

            //Next is the Readline
            stringUserInput = Console.ReadLine();



            //Last form of input is the ReadKey()
            //ReadKey() generates a return with any key pressed, not just the enter button
            //We'll talk more about ReadKey later

            //Ask the user for input
            Console.WriteLine("Type Something for Readkey:");

            //Next is the Readline
            Console.ReadKey();

            //Output resulsts of the readline
            Console.WriteLine("This statment is after the readkey");

        }
    }
}
