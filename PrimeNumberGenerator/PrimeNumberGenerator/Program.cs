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
            int i = 4;
            int pnc2 = 3;
            int pnc2assist = 24;
            int[] PrimeNumbers = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            int loopindex = 0;
            int loopindexassist = 10;
            int thirdcondition = 3;
            int whichprimenumber = 0;

            Console.WriteLine("2");
            Console.WriteLine("3");
            while (i < 100)
            {
                if (i == pnc2assist)
                {
                    if (i < 32)
                    {
                        pnc2 = 2;
                        pnc2assist += 10;
                    }
                    else if (i < 35)
                    {
                        pnc2 = 3;
                    }

                    if (loopindex > loopindexassist)
                    {
                        thirdcondition = PrimeNumbers[whichprimenumber];

                        loopindexassist += 10;
                    }
                }


                if (!((i % 2) == 0 || ((i % pnc2) == 0 && (i % thirdcondition) == 0)))
                {

                    PrimeNumbers[loopindex] = i;
                    whichprimenumber = i;
                    Console.WriteLine(i);
   
                }


                loopindex++;
                i++;
            }

        }
    }
}
