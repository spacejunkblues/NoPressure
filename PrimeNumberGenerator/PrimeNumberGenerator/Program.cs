//Marshal Fleck
//Fleckm210@gmail.com
//This is an assignment for a prime number generator
using System;

namespace PrimeNumberGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 2;
            int LoopIndex = 0;
            bool NotAPrimeNumber = false;

            //Console.WriteLine("2");
            while (i < 100)
            {
                
                for (LoopIndex = 1; LoopIndex != i - 1;LoopIndex++)
                {

                    if ((i % (LoopIndex + 1)) != 0) 
                    {
                        //might be a prime, might not be. Need to wait until end of loop

                         
                        
                        
                        
                            
                          
                    }
                    else if ((i % (LoopIndex + 1)) == 0) 
                    {
                        //Not a prime number. FOr sure.
                        NotAPrimeNumber = true;
                    }
                       
                    
                    
                }
                
                //If it is a prime number
                if (!NotAPrimeNumber) 
                {
                    Console.WriteLine(i);
                }
                NotAPrimeNumber = false;
                

                
                i++;
               
            }
            Console.WriteLine("Press any key to continue:");
            Console.ReadKey();

        }
    }
}
