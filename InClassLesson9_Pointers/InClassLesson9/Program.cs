using System;
using System.Security.Cryptography;

namespace InClassLesson9
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a random number
            //number will be 50 to 99 
            int num = RandomNumberGenerator.GetInt32(50, 100);

            //print the random number to the screen
            Console.WriteLine(num);



            //Can be used with a loop to generate a bunch of random numbers
            for (int i = 0; i < 10; i++)
            {
                num = RandomNumberGenerator.GetInt32(50, 100);
                Console.WriteLine(num);
            }
        }
    }
}
