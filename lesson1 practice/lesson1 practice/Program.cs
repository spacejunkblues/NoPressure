using System;
using System.Threading;

namespace lesson1_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; true; i++)
            {
                Thread.Sleep(10);
                Console.Write(i);
            }
        }
    }
}
