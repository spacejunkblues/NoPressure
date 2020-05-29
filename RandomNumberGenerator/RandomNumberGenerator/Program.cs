using System;
using System.Globalization;

namespace RandomNumberGenerator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            unsafe
            {

                long* ChangeRandomNumber;
                Random rnd = new Random();
                long RandomNumber;
                int HowManyNumbers;
                int i;
                bool LoopActive;
                bool LoopActive1;
                long[] RandomNumbers;
                string YesOrNo;

                RandomNumber = rnd.Next(50, 101);
                LoopActive = true;
                LoopActive1 = true;
                HowManyNumbers = 0;
                i = 0;
                YesOrNo = " ";
                

                while (LoopActive1)
                {


                        i = 0;
                        RandomNumber = rnd.Next(50, 101);
                        HowManyNumbers = 0;
                        Console.WriteLine("How many numbers would you like to generate?");
                        Console.WriteLine("(type the number, then hit enter):");
                        HowManyNumbers = (Convert.ToInt32(Console.ReadLine()));
                        RandomNumbers = new long[HowManyNumbers];
                    fixed (long* NumberToChange = RandomNumbers)
                    {

                        Console.WriteLine(" ");
                        Console.WriteLine(" ");

                        while (i < HowManyNumbers)
                        {
                            RandomNumbers[i] = RandomNumber;
                            RandomNumber = rnd.Next(50, 101);
                            i++;
                        }
                        //print the numbers to the screen.
                        while (i < HowManyNumbers)
                        {
                            Console.Write(i + 1);
                            Console.Write(". ");
                            Console.WriteLine(RandomNumbers[i]);
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
                            int NumberToChange2 = 0;


                            //Change a value
                            Console.WriteLine("Which number would you like to change?");
                            Console.WriteLine("Type the Index number to the left of the number, then hit enter:");
                            NumberToChange2 = (Convert.ToInt32(Console.ReadLine()));//NumberTochange is the index for the array "RandomNumbers"

                            NumberToChange2--; //take the input from base 1 to base 0

                            //checks to make user inputs a number that is within the index range.
                            //In other words if the size of the array is 10. They shouldn't be able to enter an 11
                            if (NumberToChange2 < RandomNumbers.Length)
                            {
                                NumberToChange[NumberToChange2] = rnd.Next(50, 101);

                                *NumberToChange = rnd.Next(50, 101);
                            }
                            else
                            {
                                Console.WriteLine("Sorry, that number does not exist.");
                            }
                           
                            //prints array to the screen
                            for (int j =0; j < HowManyNumbers;j++)
                            {
                                Console.Write(j + 1);
                                Console.Write(". ");
                                Console.WriteLine(RandomNumbers[j]);
                             
                            }


                            Console.WriteLine("Would you like to keep changing numbers, or would you like to generate new ones?");
                            Console.WriteLine("'Yes' to keep changing, 'no' to generate new ones:");
                            YesOrNo = Console.ReadLine();

                            while (LoopActive)
                            {

                                if (YesOrNo == "no")
                                {
                                    LoopActive = false;
                                }
                                else if (YesOrNo == "yes")
                                {

                                }
                                else
                                {
                                    Console.WriteLine("Sorry, try that again:");
                                }

                            }




                        }
                    }
                }
            }

            
            
        }
    }
}
