using System;
using System.Collections.Generic;
using System.Text;

namespace InClassLesson9
{

    class PrintPointer
    {
        public static void PrintAddress(IntPtr input)
        {
            unsafe
            {
                //get the address as an IntPtr
                //IntPtr address = (IntPtr)(int*)&input;
                IntPtr address = input;

                //get number of zeros that proceed the address 
                //address string will not include leading zeros
                int numOfZeros = 16 - address.ToString("x").Length;

                //formatting
                Console.Write("0x");

                //print leading zeros
                for(int i=0;i<numOfZeros;i++)
                    Console.Write("0");

                //Print Address
                Console.WriteLine(address.ToString("x"));

            }
        }
    }
}
