using System;

namespace InClassLesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            for (int j = 0; j < 10; j++)
            {
                int i = rnd.Next(97, 122);
                Console.Write((char)i);
            }

            Console.ReadLine();
        }
    }
}
