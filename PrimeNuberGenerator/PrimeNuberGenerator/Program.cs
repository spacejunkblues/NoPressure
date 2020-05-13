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
            int i = 1;
            while (i < 40) 
            {
                if (i % 2 == 0 && (i % 3 == 0) == false)
                {
                   
                    
                        Console.WriteLine(i);
                    
                }               

                i++;
            }

        }
    }
}
