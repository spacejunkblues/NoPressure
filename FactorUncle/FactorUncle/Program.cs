using System;
using System.Drawing;
using System.Dynamic;

namespace FactorUncle
{
    class Program
    {
        //function takes takes a number
        //returns array of factors
        static int[] Factorize(int number)
        {
            int[] factors=new int[1];
            int size=0;

            //search through all possible factors
            for(int i=2;i<=number;i++)
            {
                //if this is true then i is a factor of number
                if (number % i == 0)
                {
                    //create a temp array to keep old factors
                    int[] temp = factors;

                    //create the array
                    size++;
                    factors = new int[size];

                    //copy temp into new array
                    for(int j=0;j<temp.Length;j++)
                    {
                        factors[j] = temp[j];
                    }

                    //add it to the array
                    factors[size - 1] = i;

                    //remove it from testing
                    number = number / i;

                    //start over
                    i = 1;
                 }

            }
            return factors;
        }

        //fucntion that returns true if the number is whole
        static bool NumberIsWhole(double number)
        {
            if((double)(int)number == number)
                return true;
            else
                return false;
        }

        static void Main(string[] args)
        {
            //give user a message
            Console.WriteLine("Give me a number!");

            //get user input
            double number = Convert.ToDouble(Console.ReadLine());

            double num=number; //numerator
            int dem=1; //demoter



            //multiply number by ten until it's whole
            while (!NumberIsWhole(num))
            {
                num *= 10;
                dem *= 10;
            }

            //factorize num
            int[] numArray = Factorize((int)num);


            //factorize dem
            int[] demArray = Factorize(dem);

            //cancel out the like factors
            for(int i=0;i<numArray.Length;i++)
            {
                for (int j = 0; j < demArray.Length; j++)
                {
                    //if they are equal cancel them out. Make them both 1
                    if(numArray[i]==demArray[j])
                    {
                        numArray[i] = 1;
                        demArray[j] = 1;
                    }
                }
            }

            num = 1;
            //put the arrays back into the varaibles
            for (int i = 0; i < numArray.Length; i++)
                num *= numArray[i];

            dem = 1;
            //put the arrays back into the varaibles
            for (int i = 0; i < demArray.Length; i++)
                dem *= demArray[i];


            //display
            Console.Write(num);
            Console.Write("/");
            Console.Write(dem);





            //char[] Test = Readit.ReadLine();
            //char[] Test2 = Readit.ReadLine();
        }
    }
}
