using System;
using System.Runtime.InteropServices.ComTypes;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3 , 47,5,6,7,8,9,10 };

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);



            Console.WriteLine(numbers[1]);


            //can be used for any datatype

            char[] name = { 'm', 'a', 'r', 's', 'h', 'y' };
            Console.WriteLine(name);
            Console.WriteLine(" ");


            //can do it one by one
            Console.Write(name[0]);
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            //can assign to an index location
            name[3] = 'f';
            Console.WriteLine(name);

            char firstletter;
            firstletter = name[0];

            Console.WriteLine(" ");
            Console.WriteLine("Using a loop:");
            //can store values using arrays
            int i = 0;
            while (i< 10)
            {
                Console.Write(numbers[i]);
                Console.Write(" i is equal to :");
                Console.WriteLine(i);
                i++;
            }

            //Using arrays to make Readline()
            char[] color = { ' ',' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
            int input = 0;

            Console.WriteLine("\nInput a color:");

            for(i=0; i<10;i++)
            {
                input=Console.Read();

                if(input != 10 && input !=13)
                {
                    color[i] = (char)input;
                }

                if(input == 10)
                {
                    break;
                }

            }
            Console.Write("your color is:");
            Console.WriteLine(color);


            //use with while to make a readline without using "ReadLine"
            input = 0;
            i = 0;
            Console.WriteLine("\nInput a color:");
            while(input != 10)
            {
                input = Console.Read();

                if (input != 10 && input != 13)
                {
                    color[i] = (char)input;
                }
                i++;

            }
            Console.Write("your color is:");
            Console.WriteLine(color);

            //new type of loop
            foreach(int num in numbers)
            {
                Console.Write(num);
            }

            //-----------------Input a number of any digit-------------------------           
            //assume they will not enter a negative
            //gets a usable int from reads of any length

            //declare and init varaibles
            int[] allDigits = { -1 , -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 }; //capture the raw digits of one number
            int theNumber =0;//this is the number we wish to get from the user
            input = 0;//used for read() commands
            i = 0;//iternattion

            //ask the user for a number
            Console.WriteLine("\nInput a number:");

            //loop through reads, getting each digit
            while (input != 10)
            {
                input = Console.Read();

                if (input != 10 && input != 13)
                {
                    allDigits[i] = input -48;
                }
                i++;

            }
            //now, the allDigit array should have are number stores like this: {2,6,-1,-1...}
            //we are using -1's to signal the end of the number


            //Find the first -1
            //first neg value is found using the index "firstNeg"
            int firstNeg = 0;
            bool found = false;//bool flag will be true when the first negative is found

            //find the first neg
            for(i=0;i<10;i++)
            {
                if(allDigits[i]==-1 && !found)
                {
                    firstNeg = i;
                    found = true;
                }

            }

            //go backwards through the array, starting at the first negative.
            //multiply each digit by it's approtaite tens positions. ie, 26 is.... 2 x 10  +  6 x 1
            int TimesAmount = 1; //used to muptiply each digit, increases by a factor of ten

            //loops until it reachs the start of the array
            for (i = firstNeg - 1; i != -1; i--) 
            {
                theNumber += allDigits[i] * 1 * TimesAmount;
                TimesAmount *= 10;
            }
            //theNumber now has the result "26"




            Console.Write("your number is:");
            Console.WriteLine(theNumber);
        }
    }
}
