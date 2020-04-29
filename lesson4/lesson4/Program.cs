//marshal fleck
//april 24, 2020
//fleckm210@gmail.com
//an assignment for a calculator
using System;

namespace lesson4
{
    class MainClass
    {
         static void Main(string[] args)
        {
            //declare varaibles
            int mathanswer1;
            int mathanswer2;
            int additionmathfinalanswer;
            int multiplicationmathfinalanswer;
            int subtractionmathfinalanswer;
            float devisionmathfinalanswer;
            int userinput1;
            int userinput2;
            int userinput3;
            int userinput4;

            //init variables

           
            //Getting the first number
            Console.WriteLine("this a culculator. 2 digits, then enter:");
            userinput1 = Console.Read();
            userinput2 = Console.Read();
            Console.Read();
            Console.Read();
            Console.WriteLine(" ");

            //Get the second number
            Console.WriteLine("again: ");
            userinput3 = Console.Read();
            userinput4 = Console.Read();
            Console.Read();
            Console.Read();
            Console.WriteLine(" ");

            //combine the digits to get the actual numbers

            
            mathanswer1 = (userinput2 - 48) + ((userinput1 - 48) * 10);
            mathanswer2 = (userinput4 - 48) + ((userinput3 - 48) * 10);
            Console.Write(" ");
             
            //actually do the math
            devisionmathfinalanswer = ((float)mathanswer1 / mathanswer2);        
            multiplicationmathfinalanswer = mathanswer1 * mathanswer2;
            subtractionmathfinalanswer = mathanswer1 - mathanswer2;
            additionmathfinalanswer = mathanswer1 + mathanswer2;
            
            //output the math to the user
            Console.Write("addition:");
            Console.WriteLine(additionmathfinalanswer);
            Console.Write("subtraction:");
            Console.WriteLine(subtractionmathfinalanswer);
            Console.Write("multiplication:");
            Console.WriteLine(multiplicationmathfinalanswer);
            Console.Write("devision:");
            Console.WriteLine(devisionmathfinalanswer);






            Console.WriteLine("press any key to continue:");
            Console.ReadKey();


        }
    }
}
