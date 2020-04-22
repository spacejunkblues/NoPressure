// Marshal Fleck
// fleckm210@gmail.com
// 21 Apr 2020
// Lesson 2
// 
// This project was given to me by the greatest Uncle on the face of the Earth. Maybe even the galaxy, theres no telling really.
// It focusseseses on data types and varaibles

using System;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {            
            // these are int identifiers which indentifies the variable type and name
            bool bl;
            int it;
            char ch;
            uint ut;
            float ft;
            long lng;

            // this is the assign area, where we assign the values for the variables 
            lng = 9223372036854775807;
            ft = 3.2f;
            ut = 4294967295;
            bl = true;
            it = 2147483647;

            // this the character or "char" variable. it can be stored with unique characters like letters or symbols
            ch = (char)104;

            //Completes a sentence using a varaible from above.
            Console.Write("This statment is ");
            Console.Write(bl);
            Console.WriteLine(".");
            Console.WriteLine(" ");

            //New Sentence using more varaibles.
            Console.Write("The number ");
            Console.Write(it);
            Console.Write(" is smaller than the number ");
            Console.Write(ut);
            Console.Write(", which is also smaller than the number ");
            Console.Write(lng);
            Console.WriteLine(".");

            //Completes a sentence using more varaibles from above.
            Console.Write("The numnber ");
            Console.Write(ft);
            Console.Write(" is a number, unlike the letter/symbol '");
            Console.Write(ch);
            Console.WriteLine("'. ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");


        }
    }
}
