using System;

namespace PrimeNumUncle
{
    class Program
    {
        static int PrimeRecur(int i)
        {
            if (i <= 1)
                return 2;

            //Get the next number after the last prime number
            int currentPrime = PrimeRecur(i - 1) +1;

            //Test to see if the current primenumber is valid by checking it agaisnt all prevous prime numbers
            for(int j=1;j<i;j++)
            {
                //This means it's divisible by a previous prime number. So it's not a prime number
                if (currentPrime % PrimeRecur(j) == 0)
                {
                    currentPrime++;
                    j = 1;
                }
            }

            return currentPrime;
        }
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
                //for (int counter = 0; counter < 100000000; counter++) ;
            }

            Console.WriteLine("\nPrime Numbers from recur");
            for (i = 1; i < 25; i++)
            {
                Console.WriteLine(PrimeRecur(i));
            }
           
        }
    }
}
