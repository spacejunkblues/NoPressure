using System;

namespace InClassLesson11_Functions
{
    class Program
    {
        static string GiveMeAName()
        {
            return "Jim";
        }










        //We can name the string anything we want, the name does not need to match!
        static void Greet(string name)
        {
            Console.Write("Hello ");
            Console.Write(name);
            Console.WriteLine("!");

        }













        static void OurMessage()
        {
            //Ever write code that you want to use over and over again?
            Console.WriteLine("This is code that prints a message to the screen.");
            Console.WriteLine("Maybe it's printing an array to the screen, or just a message you want to repeat often");
            Console.WriteLine("It's clean at first, but the second you want to use it again. You find yourself coping and pasting!!\n");

        }













        static void Main(string[] args)
        {
            //Ever write code that you want to use over and over again?
            Console.WriteLine("This is code that prints a message to the screen.");
            Console.WriteLine("Maybe it's printing an array to the screen, or just a message you want to repeat often");
            Console.WriteLine("It's clean at first, but the second you want to use it again. You find yourself coping and pasting!!\n");

            //like this
            Console.WriteLine("This is code that prints a message to the screen.");
            Console.WriteLine("Maybe it's printing an array to the screen, or just a message you want to repeat often");
            Console.WriteLine("It's clean at first, but the second you want to use it again. You find yourself coping and pasting!!\n");











            //Coping and pasting can work at first, but now try to change the message!
            //A better way is to make a function.
            //We can throw that code into a function! and make it easy to re-use
            OurMessage();

            //We can now use the function over and over
            OurMessage();
            OurMessage();
            OurMessage();
            OurMessage();

            //Try changing the message and see how it will much easier it is.






















            //We can also pass a "parameter" to the function take the example below

            //Ever write code that you want to use over and over again?
            string name = "Uncle";

            Console.Write("Hello ");
            Console.Write(name);
            Console.WriteLine("!");

            //like this
            name = "Marshy";

            Console.Write("Hello ");
            Console.Write(name);
            Console.WriteLine("!");

            //in this case we are printing the same thing over and over, and just changing one varaible. So let's pass it.
            Greet("Guy");


























            //We can also get a return from a function
            string dudeName;

            dudeName = GiveMeAName();

            Console.WriteLine(dudeName);


            //create Add function inclass!
        }
    }
}
