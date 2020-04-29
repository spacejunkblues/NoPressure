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
            bool bl;
            bool bl2;

            //*****************artiemtic OPerators*******************
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

            //x = Console.Read();

            //**************Unmary Operators*****************

            //using ++
            y++;

            //same thing as
            y = y + 1;

            //computes the answer on the same line
            ++y;

            Console.WriteLine(y++);
            Console.WriteLine(++y);

            //y starts as a 7
            //it will print a 12
            //y value will be 8
            y = 7;
            Console.WriteLine(y++ + 5);

            //y starts as a 7
            //it will print a 13
            //y value will be 8
            y = 7;
            Console.WriteLine(++y + 5);

            //y starts as a 7
            //it will print a 13
            //y value will be 13
            y = 7;
            Console.WriteLine(y = ++y + 5);

            //y-- subtracts instead of adds, works like ++

            //using a minus sign
            y = 7;
            Console.WriteLine(-y);

            y = -y;

            //Booleans
            bl = true;

            bl = !bl;

            bl = !false;

            //***************Relational Operators*******************************
            bl = true == false;

            bl = false;
            bl2 = false;

            Console.WriteLine(bl == bl2);


            bl = 2 < 3; //True
            bl = 3 < 3; //False

            bl = 3 <= 3; //TRue  becasue     3 < 3 is false but 3 == 3 is true, as long as one is true, the whole statement is true.

            bl = 3 == 3; //true


            bl = 3.0 != 3; //false

            //can use chars aswell

            bl = '\n' == 10;

            bl = 'a' < 'b'; //true

            //what about this?
            bl = 'A' < 'b'; //True
            bl = 'a' < 'B'; //False

            //   || is true as long as one value (left or right) is true
            bl = true || false; //true
            bl = false || true; //true
            bl = true || true; //true
            bl = false || false; //false


            // && is true only when both are true
            bl = true && false; //false

            bl = false && true; //false

            bl = true && true; //true

            bl = false && false; //false

            Console.WriteLine(true && true);
            Console.WriteLine(false && true);
            Console.WriteLine(true && false);
            Console.WriteLine(false && false);

            //**************compound operators ******************

            y = 5;
            y += 3;

            //****************bit Wise*****************
            x = 2;
            Console.WriteLine(x & 1);


            Console.WriteLine(x & 1);

            //
            int cool_rating = 0 ;
            int skateboardingFlag = 16;

            x = 12; //this is age


            cool_rating = (int)x | skateboardingFlag;


            //
            cool_rating = 5 & 7;
            cool_rating = 5 | 7;


            cool_rating = 6 & 5;

            Console.WriteLine(4 >> 1);
            Console.WriteLine(4 << 1);


            Console.WriteLine(5 << 2);
            Console.WriteLine(5 >> 1);

            Console.WriteLine(5 / 2);
            string myname;
            
            name = "marshy";


            Console.WriteLine("Press Any Key");
            Console.ReadKey();
        }
    }
}
