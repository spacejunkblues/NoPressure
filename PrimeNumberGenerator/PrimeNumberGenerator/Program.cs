//Marshal Fleck
//Fleckm210@gmail.com
//This is an assignment for a prime number generator
using System;

namespace PrimeNuberGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int[] PrimeNumbers = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
 
            while (i < 100)
            {

                if (i > 10)
                {

                    if ((i % 2) != 0 && (i % 3) != 0 && (i % 10) != 0 && (i % 5) != 0 && (i % 7) != 0)
                    {

                        Console.WriteLine(i);

                    }
                    else if ()
                    {

                    }



                }
                


               
                i++;
            }

        }
    }
}
