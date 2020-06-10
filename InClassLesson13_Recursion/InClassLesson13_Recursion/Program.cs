using System;
using System.ComponentModel;
using System.Diagnostics.Tracing;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;

namespace InClassLesson13_Recursion
{
    class Program
    {
        //use this magic line to create a datatype for functions.
        //parameters and return value must match or it can't be passed into that type
        //Think of it as a datatype definition
        private delegate int mathFuncDataType(int num1, int num2);

        static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }
        static int Divide(int num1, int num2)
        {
            return num1 / num2;
        }

        static int DoMath(int num1,int num2, mathFuncDataType SomeMathFunc )
        {
            return SomeMathFunc(num1, num2);

        }


        static void Test()
        {
            int x;
            Test();
        }

        static void Count(int x)
        {
            Console.WriteLine(x);

            if (x == 10)
                return;

            Count(x + 1);


            Console.WriteLine(x);
        }

        //returns a fib number given it's placement, it returns the number. IE, 8 will return 21
        //Parameter:
        //1 2 3 4 5 
        //Return:
        //1 1 2 3 5
        static int Fib(int num)
        {
            int num1 = 1;
            int num2 = 1;
            int nextnum = 0;
            int count;

            //needed to return if they wanted the first two fibs
            if (num == 1)
                return 1;
            else if (num == 2)
                return 1;
            else
                count = 3;

            //Do the fib process for the tird value and up
            while (count<=num)
            {
                nextnum = num1 + num2;
                num1 = num2;
                num2 = nextnum;

                count++;
            }
            return nextnum;
        }

        static int FibRecur(int i)
        {
            if (i == 2)
                return 1;
            else if (i == 1)
                return 1;
            else
                return FibRecur(i - 2) + FibRecur(i - 1);

        }

        static void Main(string[] args)
        {
            //Create Test recurrsion function showing how a function can call itself+

            //Test();
            //Create a Count function
            Count(0);

            //step through code to show how it acts like a function

            //print x before the call and after to show how it acts like a stack

            //Explain the stack... how many x varibles exist in memory??

            //write the fibancii squence using recurrsion


            int answer;

            mathFuncDataType SomeFunction;

            SomeFunction = Add;

            answer= SomeFunction(6,7);

            SomeFunction = Subtract;


            // answer=DoMath(2,3,"add");


            //            answer = DoMath(2, 3, "multiply");
            //          answer = DoMath(2, 3, "subtract");

            answer = DoMath(3, 4, Add);
            answer = DoMath(8, 2, Divide);






            //Call back functions (method means function)

            //make a calculator function that takes in a function as a parameter

            //make an add and multi function to show the choice

            //example of how another function can actually be used to set the function


            Console.WriteLine("\n\n Fib:\n");

            Console.WriteLine(Fib(20));

            Console.WriteLine("\n\n FibRecur:\n");

            Console.WriteLine(FibRecur(8));

        }
    }
}
