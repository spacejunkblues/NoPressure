//Marshal Fleck
//Fleckm210@gmail.com
//This is an assignment for a quiz that uses functions
using System;

namespace Quiz2
{
    class MainClass
    {


        static string[] Q1(ref String[][] Q1, int index)
        {
            int i = 0;
            Console.WriteLine("Hello this is the question function.");
            Console.WriteLine("What is the questiion?");
            Console.WriteLine("The first sentence is the question.");
            Console.WriteLine("The other 3 are the possible answers.");
            Q1[index] = new string[4];
            while (i < 4)
            {
                Console.Write(i + 1);
                Console.WriteLine(". :");
                Q1[index][i] = Console.ReadLine();
                i++;
            }
            
            return Q1[index];
        }

        static string[] Q2(ref string[][] Q2)
        {
            Q1(ref Q2, 1);
            return Q2[1];
        }


        public static void Main(string[] args)
        {
            string[][] Questions = new string[4][];

            Q1(ref Questions, 0);
            int i = 0;

            Console.Write(i + 1);
            Console.WriteLine(". :");
            while (i < 4)
            {
                Console.WriteLine(Questions[0][i]);
                i++;
            }
            

        }
    }
}
