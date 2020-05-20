//Marshal Fleck
//Fleckm210@gmail.com
//This is an asignment for a Fraction Generator
using System;

namespace FractionGenerator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Declaring variables
            decimal UserNumber;
            decimal Denominator;
            decimal Numerator;
            bool LoopActivated;

            //Init variables
            UserNumber = 0;
            LoopActivated = true;
            Denominator = 1;
            Numerator = 0;

            while (LoopActivated)
            {
                Numerator = 0;
                Console.WriteLine("Hello, this is a Fraction Generator.");
                Console.WriteLine("Type the number you want to be converted, then hit enter:");
                UserNumber = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Numerator = UserNumber;

                if (Denominator > UserNumber)
                {
                    Numerator = UserNumber + (Denominator - UserNumber);
                    Denominator = Denominator / (Denominator -(Denominator - UserNumber));
                    
                    Console.WriteLine(Numerator);
                    Console.WriteLine("-");
                    Console.WriteLine(Denominator);
                }

                

                

            }

        }
    }
}
