using System;
using System.ComponentModel;

namespace InClassLesson11_Functions
{
    class Program
    {
        static string GiveMeAName()
        {
            return "Jim";
        }










        //We can name the string anything we want, the name does not need to match!
        static void Greet(string name,int x)
        {
            Console.Write("Hello ");
            Console.Write(name);
            Console.WriteLine("!");
            Console.Write(x);

        }

        static float Wrapper(int num1,int num2)
        {

            if (num1 != 0 && num2 != 0)
            {
                float ans = 0;
                ans = (float)num1 / (float)num2;
                return ans;
            }
            else
            {
                Console.WriteLine("Sorry, cannot devide by 0!.");
                return 0;
            }
        }

        static float Devision(double num1, double num2)
        {

            float ans;

            ans = Wrapper((int)num1, (int)num2);

            return ans;
        }

        static float Devision(int num1, int num2) 
        {

            float ans;

            ans = Wrapper(num1, num2);

            return ans;
        }

        static float Devision()
        {

            float ans;

            ans = 0;

            return ans;
        }








        static void OurMessage()
        {
            //Ever write code that you want to use over and over again?
            Console.WriteLine("This is code that prints a message to the screen.");
            Console.WriteLine("Maybe it's printing an array to the screen, or just a message you want to repeat often");
            Console.WriteLine("It's clean at first, but the second you want to use it again. You find yourself coping and pasting!!!\n");

        }




        static string[][] CreateMyArray()
        {
            return new string[10][];
        }


        static int Add(int num1,int num2)
        {
            int ans;

            ans = (int)ActualAdd((double)num1, (double)num2);

            return ans;
        }


        static double Add(double num1, double num2)
        {
            return ActualAdd((double)num1, (double)num2);
        }
        static long Add(long num1, long num2)
        {
            return (long)ActualAdd((double)num1, (double)num2);
        }

        static double ActualAdd(double num1, double num2)
        {
            num1 += num2;
            return num1;

        }

        static void GetMyData(ref string name,ref int age)
        {
            name = "uncle";
            age = 35;
        }



        static void Main(string[] args)
        {
            //Ever write code that you want to use over and over again?
            Console.WriteLine("This is code that prints a message to the screen.");
            Console.WriteLine("Maybe it's printing an array to the screen, or just a message you want to repeat often");
            Console.WriteLine("It's clean at first, but the second you want to use it again. You find yourself coping and pasting!!!\n");

            //like this
            Console.WriteLine("This is code that prints a message to the screen.");
            Console.WriteLine("Maybe it's printing an array to the screen, or just a message you want to repeat often");
            Console.WriteLine("It's clean at first, but the second you want to use it again. You find yourself coping and pasting!!!\n");











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
            Greet("Guy",0);
            Greet("Dude",4);
            Greet("There",6);


            























            //We can also get a return from a function
            string dudeName;

            dudeName = GiveMeAName();

            Console.WriteLine(dudeName);


            //create Add function inclass!
            int sum;

            sum = Add(6, 7);

            Console.Write("\n\nSum: ");
            Console.WriteLine(sum);

            sum = Add(7, 8);




            float dev = 0;
            dev = Devision(6, 5);


            dev = Devision(6.2, 0);
            Console.WriteLine(dev);


            //----pass by reference----

            string myname="";
            int myage=0;

            GetMyData(ref myname, ref myage);



            Add(.3, .5);

            Devision();

            string[][] questions;

            questions = CreateMyArray();

        }//END OF MAIN
    }
}
