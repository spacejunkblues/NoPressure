using System;

namespace Satisfying_Code
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            
            while (true)
            {
                
                Random rnd = new Random();
                int month = rnd.Next(1, 1000000000);  // creates a number between 1 and 12
                int dice = rnd.Next(1, 7);   // creates a number between 1 and 6
                int card = rnd.Next(52);     // creates a number between 0 and 51
                Console.Write(month);


                   
                
            }
        }
    }
}
