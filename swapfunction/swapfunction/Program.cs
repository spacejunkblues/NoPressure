using System;

namespace swapfunction
{
    class Program
    {
        static void SwapFunction<T>(ref T var1, ref T var2)
        {
            //This is the placeholder for var1 or variable1
            T PHD;

            //assigning the placeholder to var1
            PHD = var1;

            //swapping the variables
            var1 = var2;
            var2 = PHD;
        }

        static void ClearsSpace()
        {
            //Clears space
            Console.WriteLine(" ");
            Console.WriteLine(" ");
        }

        static void Main(string[] args)
        {
            //created number array for test
            int[] TestArray;

            //populating array for test
            TestArray = new int[2];
            TestArray[0] = 1;
            TestArray[1] = 2;

            //asks the user for ints
            Console.WriteLine("Hello, this is the swap program.");
            Console.WriteLine("What is the first number you would like to be swapped?");
            try 
            {
                TestArray[0] = Convert.ToInt32(Console.ReadLine());
            }
            catch 
            {
                
            }

            try 
            {
                Console.WriteLine("And the Second?");
                TestArray[1] = Convert.ToInt32(Console.ReadLine());
            }
            catch 
            {
                
            }

            //Clears space
            ClearsSpace();

            //swaps the variables using the swap function
            SwapFunction(ref TestArray[0], ref TestArray[1]);

            ClearsSpace();

            //displays results to user
            Console.Write("Numbers ");
            for (int i = 0; i < TestArray.Length -1; i++) 
            {
                Console.Write(TestArray[i]);
                Console.Write(" and ");
            }
            Console.Write(TestArray[TestArray.Length - 1]);
            Console.Write(" have been swapped.");
        }
    }
}
