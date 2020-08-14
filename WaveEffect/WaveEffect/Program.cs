using System;
using System.Threading;

namespace WaveEffect
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            for (int j = 1; j < 3; j++)
            {
                Console.SetCursorPosition(0, 0);
                for (int i = 0; i < 2000; i++)
                {
                    Console.Write(j);
                    Thread.Sleep(5);
                }
            }

            Console.ReadKey();
        }
    }
}
