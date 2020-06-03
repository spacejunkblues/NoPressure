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
        static void SomeFunction(int age)
        {
            if(age < 0)
            {
                Console.WriteLine("I'm in the age<0 if statement");
                throw new Exception("Age has to be greater then 0");
            }
            Console.WriteLine("I'm at the end of SomeFunction");
        }

        static void Main(string[] args)
        {
            int x;

            //example of when an error can occur
            Console.WriteLine("Type a number and it works. But try typing 'hello':");
            x = Convert.ToInt32(Console.ReadLine());


            //Do an example of try catch using
            try
            {
                Console.WriteLine("I'm in the try!");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("I'm in the try after the readline"); //everything after the error is throw, will get skipped. If theres an error

            }
            catch (Exception e)//this will get skipped if the try works without error
            {
                Console.WriteLine("I'm in the catch!");

                //show how catch can get passed an Exception parameter
                Console.WriteLine(e.Message);
            }


            //Call SomeFunction here that shows how to create an error using throw
            try
            {
                SomeFunction(-1);

            }
            catch(Exception MyError)
            {
                Console.WriteLine(MyError.Message);
            }



            //Go over sleeps for fun
            Console.WriteLine("One");
            //1000 miliseconds is 1 second
            Thread.Sleep(1000);
            Console.WriteLine("Two");
            Thread.Sleep(1000);
            Console.WriteLine("Three");
            Thread.Sleep(1000);



        }
    }
}
