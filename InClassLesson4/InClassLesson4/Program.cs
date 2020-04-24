using System;

namespace InClassLesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            long x;
            int y;
            char ch;
            string name;
            float xfloat;

            y = 2;

            //complier can stuff an int into a long
            x = y;

            //can't stuff a long into an int
            //y = x;

            ch = 'h';


            // can't do this:
            //1 = y;

            //works
            x = y + 2;


            //this operator supports Char + Int
            x = ch + 2;

            //x should be 106
            name = "Fred";

            // string + string puts them together "concat"
            name = "Fred" + "Smith";

            //math opertors work mostly how you would expect
            x = 4 - 2;

            //order of precedence works just like in math
            x = (ch + y) * 3;
            x = ch + (y * 3);

            x = ch + y * 3;

            //will just do left to right
            x = 1 + 2 + 3;

            Console.Write("Paraenthsis change meaning");


            //type casting from a double/float into an int or a long, will truncate the value
            x = (int)1.7;
            x = (int)5.7;


            //division operator returns the same datatype it's given
            x = 3 / 2;
            xfloat = 3 / 2.0f;


            //Mod opertor returns the remainder
            x = 1 % 3;
            x = 2 % 3;
            x = 3 % 3;
            x = 4 % 3;
            x = 5 % 3;
            x = 6 % 3;
            x = 7 % 3;
            x = 8 % 3;
            x = 9 % 3;

            x = Console.Read();
        }
    }
}
