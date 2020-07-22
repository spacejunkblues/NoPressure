using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace InClass_Lambda
{
    class Program
    {
        static int multi(int x)
        {
            return x * x;
        }
        static void Main(string[] args)
        {
            Func<int, bool> multi2 = x =>
             {
                 Console.Write("Hello!!!!");
                return x == 8;
             };

            //bool y = multi2(10);

            if (true)
            {
                //do stuff;
            }

        }
    }
}
