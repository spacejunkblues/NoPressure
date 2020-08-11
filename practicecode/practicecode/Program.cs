//marshal fleck
//using visual studios 
//april 22, 2020
//practicing some code
//
//
using System;

namespace practicecode
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("type the word you want to show backwards:");
            string v = Console.ReadLine();

            for (int i = v.Length; i > 0; i--)
            {
                Console.Write(v[i]);
            }

        }
    }
}
