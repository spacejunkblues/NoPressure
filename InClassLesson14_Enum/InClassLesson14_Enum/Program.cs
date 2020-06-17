using System;
//must add this using:
//using System.Collections.Generic;

//This program is mis-named. We aren't doing enums yet, flex to generic types and vars

namespace InClassLesson14_Enum
{
    
    class Program
    {
        delegate T DoMath<T>(T num1, T num2);

        static void test<MYDataType>(MYDataType z)
        {

            MYDataType k;

            k = z;
            Console.WriteLine(k);

        }


        static T GetSecond<T>(T num1, T num2)
        {
            return num2;
        }

        static T add<T>(T num1, T num2)
        {
            Console.WriteLine("I'm adding");
            return num2;
        }

 
        static T subtract<T>(T num1, T num2)
        {
            Console.WriteLine("I'm subtracting");
            return num2;
        }

        static void Main(string[] args)
        {
            var x=3;

            Console.WriteLine(x);


            test<char>('5');
            test<double>(3);

            //introduce <> Operator

            //Show how it can be used in the function, as a parameter, and as a return. Note: All the T's are the same datatype!
            Console.WriteLine(GetSecond<float>(2, 3));

            var number = GetSecond<double>(4, 5);



            var number2 = GetSecond(4, 5);

            //show how it will figure it out

            //show how to force it to be a data type

            //type the delegate statment up above. Make it an int.
            DoMath<int> func= add;

            func(2, 3);

            func = subtract;

            func(1, 2);

            //create the callback function

            //show it works

            //create a second callback function using a different datatype

            //use var



        }
    }
}
