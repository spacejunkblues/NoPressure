//This an Assignment for a Char Array simulating a string
using System;
using personspace;
using masrshy;


namespace stringobject
{
 

	class Program
    {
        public static void Main(string[] args)
        {
            char[] chay = new char[5];

            chay[0] = 'k';

            Mstring name1 = new Mstring();
            Mstring name2 = new Mstring(chay);


            //name1.AppendString(chay);
            Console.WriteLine(name1.GetString());

            name1.SetString("aa");
            name2.SetString("aab");
            if (name1 > name2)
            {
                Console.WriteLine("Name1 is greater!");
            }
            else
                Console.WriteLine("Name2 is greater!");

            Person me = new Person();
            me.name = "helo";

            Console.ReadLine();

            //use of goto's
            for (int j = 0; j < 1000000; j++)
            {
                for (int i = 0; i < 100000; i++)
                {
                    if (i == 2)
                    {
                        goto endofloop;
                    }
                }

            }

        endofloop:

            Console.WriteLine($"needs code after it {me.name}.");

            //jump out of both loops when you found i is 10
        }
    }
}
