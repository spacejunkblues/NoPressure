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

            int mathanswer1;
            int mathanswer2;
            int additionmathfinalanswer;
            int multiplicationmathfinalanswer;
            int subtractionmathfinalanswer;
            int devisionmathfinalanswer;
            int userinput1;
            int userinput2;
            int userinput3;
            int userinput4;

            Console.WriteLine("this a culculator. 2 digits, then enter:");
            userinput1 = Console.Read();
            userinput2 = Console.Read();
            Console.Read();
            Console.Read();
            Console.WriteLine(" ");

            Console.WriteLine("again: ");
            userinput3 = Console.Read();
            userinput4 = Console.Read();
            Console.Read();
            Console.Read();
            Console.WriteLine(" ");

            mathanswer1 = ((char)userinput2 + ((char)userinput1 * 10));
            mathanswer2 = ((char)userinput4 + ((char)userinput3 * 10));
            Console.Read();
            Console.Read();
            Console.Write(" ");
             

            devisionmathfinalanswer = (mathanswer1 / mathanswer2);        
            multiplicationmathfinalanswer = (mathanswer1 * mathanswer2);
            subtractionmathfinalanswer = (mathanswer1 - mathanswer2);
            additionmathfinalanswer = (mathanswer1 + mathanswer2);
            
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
