using System;

namespace PrimeNumUncle
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] primeNumbers = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            int len = 0;
            int i = 1;
            bool primeNumber = true;
            

            while(len<primeNumbers.Length)
            {
                for(int j=0; j<len; j++)
                {
                    if(i%primeNumbers[j]==0)
                        primeNumber = false;
                }

                if (primeNumber && i!=1)
                    primeNumbers[len++] = i;

                primeNumber = true;
                i++;
            }

            foreach (int num in primeNumbers)
            {
                Console.WriteLine(num);

                //Timer
                for (int counter = 0; counter < 100000000; counter++) ;
            }



           
        }
    }
}
