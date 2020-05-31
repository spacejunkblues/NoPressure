using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace InClassLesson12_ErrorCatch
{
    class Program
    {
        //You can create an error message using the following code
        //throw new Exception("Here's an error");

        static void Main(string[] args)
        {
            int x;

            //example of when an error can occur
            Console.WriteLine("Type a number and it works. But try typing 'hello':");
            x = Convert.ToInt32(Console.ReadLine());


            //Do an example of try catch using
            //x = Convert.ToInt32(Console.ReadLine());

            //show how to catch an error

            //shows how code gets skipped when an error is caught

            //show how catch can get passed an Exception parameter

            //Call SomeFunction here that shows how to create an error using throw

            //Give an example on how throws can be used with try-catch


            //Go over sleeps for fun
            //Console.WriteLine("One");
            //1000 miliseconds is 1 second
            //Thread.Sleep(1000);



        }
    }
}
