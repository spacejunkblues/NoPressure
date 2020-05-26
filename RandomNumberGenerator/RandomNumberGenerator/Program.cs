using System;
namespace RandomNumberGenerator
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Random rnd = new Random();
            int RandomNumber;
            int HowManyNumbers;
            int i;
            bool LoopActive;
            int[] RandomNumbers;

            RandomNumber = rnd.Next(50, 101);
            LoopActive = true;
            HowManyNumbers = 0;
            i = 0;

                
            Console.WriteLine("How many numbers would you like to generate?");
            Console.WriteLine("(type the number, then hit enter):");
            HowManyNumbers = (Convert.ToInt32 ( Console.ReadLine()));
            RandomNumbers = new int[HowManyNumbers];

            Console.WriteLine(" ");
                Console.WriteLine(" ");

                while (i < HowManyNumbers)
                {
                    RandomNumbers[i] = RandomNumber;
                    RandomNumber = rnd.Next(50, 101);
                    i++;
                }
            while (LoopActive)
            {
                i = 0;

                //print the numbers to the screen.
                while (i < HowManyNumbers)
                {
                    Console.Write(i + 1);
                    Console.Write(". ");
                    Console.WriteLine(RandomNumbers[i]);
                    i++;
                }
                int NumberToChange = 0;  


                //Change a value
                Console.WriteLine("Which number would you like to change?");
                Console.WriteLine("Type the Index number to the left of the number, then hit enter:");
                NumberToChange = (Convert.ToInt32(Console.ReadLine()));//NumberTochange is the index for the array "RandomNumbers"

                NumberToChange--; //take the input from base 1 to base 0

                //checks to make user inputs a number that is within the index range.
                //In other words if the size of the array is 10. They shouldn't be able to enter an 11
                if (NumberToChange < RandomNumbers.Length)
                {
                    RandomNumbers[NumberToChange] = rnd.Next(50, 101);
                }
                else
                {
                    Console.WriteLine("Sorry, that number does not exist.");
                }
                

                Console.WriteLine("Press any key to continue:");
                Console.ReadKey();



            }
            
        }
    }
}
