using System;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace InClassLesson9
{
    class Program : PrintPointer
    {
        static void Main(string[] args)
        {
            //------------------------RANDOM----------------------------------------
            //create a random number
            //number will be 50 to 99 
            int num = RandomNumberGenerator.GetInt32(50, 100);

            //print the random number to the screen
            Console.WriteLine(num);






            //Can be used with a loop to generate a bunch of random numbers
            for (int i = 0; i < 10; i++)
            {
                num = RandomNumberGenerator.GetInt32(50, 100);
                Console.WriteLine(num);
            }

















            //------------------------POINTERS----------------------------------------
            int y = 4;
            Console.Write("y: ");
            Console.WriteLine(y);


            //doesn't work in unsafe context
            //int* x;

















            //had to goto project -> Properties -> build -> check the "allow unsafe"
            unsafe
            {
                int* yAddress = &y;

                //Gives error
                //Console.Write(yAddress); 

                //print it to the screen
                PrintAddress((IntPtr)yAddress);

                *yAddress = 5;

                Console.Write("y: ");
                Console.WriteLine(y);


                













                
                

                //now lets try to use it with an Array
                int[] numArray = { 71, 22, 53 };

                //int* xPtr;

                //Gives Error
                //xPtr = &numArray[0];

                //Need it to be fixed (arrays move in memory)
                fixed(int* numPtr = &numArray[0])
                {
                    int* xPtr = numPtr;

                    Console.Write("*xPtr: ");
                    Console.WriteLine(*xPtr);

                    Console.Write("xPtr[0]: ");
                    Console.WriteLine(xPtr[0]);

                    Console.Write("xPtr[1]: ");
                    Console.WriteLine(xPtr[1]);

                    Console.Write("xPtr[2]: ");
                    Console.WriteLine(xPtr[2]);

                    xPtr += 1;

                    //Copy and paste the output from above




                    *xPtr = 27;

                    //Print the original array
                    Console.WriteLine("Print Array");

                    foreach (int number in numArray)
                    {
                        Console.Write("number :");
                        Console.WriteLine(number);
                    }




                    Console.WriteLine(*xPtr);
                    Console.WriteLine(xPtr[0]);
                    Console.WriteLine(xPtr[1]);
                    xPtr[1] = 99;

                    //Print the original array
                    Console.WriteLine("Print Array");

                    foreach (int number in numArray)
                    {
                        Console.Write("number :");
                        Console.WriteLine(number);
                    }

    
                    

                }//End of fixed

            }//end of Unsafe



            //----------------------------new demo------------------------------------------------

















                //--------------------Using dynamic memory with pointers------------------------------------
            unsafe
            {
                int[] days;
                int[] two;


                //Console.Write(new char[10]);

                days = new int[7];
                two = days;

                //days[10] = 10;

                days[0] = 3;
                //int* x;


                int size = 10;
                char[] name = new char[size];

                //doesn't work, needs to be fixed
                //x = &(new int[3])[0];

                fixed (int* x = new int[3])
                {
                    x[0] = 1;
                    x[1] = 2;
                    x[2] = 3;
                    //x[3] = 4;

                    Console.Write("x[0]: ");
                    Console.WriteLine(x[0]);

                    Console.Write("x[1]: ");
                    Console.WriteLine(x[1]);

                    Console.Write("x[2]: ");
                    Console.WriteLine(x[2]);

                   // Console.Write("x[3]: ");
                   // Console.WriteLine(x[3]);

                    Console.Write("x: ");
                    Console.WriteLine(*x);
                }
            }//end of unsafe

            //Console.WriteLine(two);

        }
    }
}
