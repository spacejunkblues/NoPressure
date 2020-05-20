using System;

namespace SquareRootUncle
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare varaibles
            int UserNumber;
            decimal i;

            //get number to be square rooted
            UserNumber = Convert.ToInt32(Console.ReadLine());

            i = 1;
            decimal decPlace = 1;

            while(decPlace > (decimal).0000000000001)
            {
                //I've gone to far
                if(i*i > UserNumber)
                {
                    //subtract one from the current decimal place
                    i = (decimal)i - (decimal)decPlace;

                    //move to the next decmcal place
                    decPlace = decPlace / 10;
                }

                //inc the decimal place we working on
                i = i + (decimal)decPlace;
            }

            Console.WriteLine(i);
        }
    }
}
