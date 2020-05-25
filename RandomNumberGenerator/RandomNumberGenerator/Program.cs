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
            int[] RandomNumbers = { 0, 0, 0, 0, 0, 0, 0 };

            RandomNumber = rnd.Next(50, 101);
            LoopActive = true;
            HowManyNumbers = 0;
            i = 1;

            
                i = 1;
                Console.WriteLine("How many numbers would you like to generate?");
                Console.WriteLine("(type the number, then hit enter):");
                HowManyNumbers = (Convert.ToInt32 ( Console.ReadLine()));
                RandomNumbers = new int[HowManyNumbers + 1];

                Console.WriteLine(" ");
                Console.WriteLine(" ");

                while (i <= HowManyNumbers)
                {
                    RandomNumbers[i] = RandomNumber;
                    RandomNumber = rnd.Next(50, 101);
                    i++;
                }
            while (LoopActive)
            {
                i = 1;
                while (i <= HowManyNumbers)
                {
                    Console.Write(i);
                    Console.Write(". ");
                    Console.WriteLine(RandomNumbers[i]);
                    i++;
                }
                int NumberToChange = 0;  

                Console.WriteLine("Which number would you like to change?");
                Console.WriteLine("Type the Index number to the left of the number, then hit enter:");
                NumberToChange = (Convert.ToInt32(Console.ReadLine()));
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
