using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Transactions;
using marshcode;

namespace InClassLesson19_Enum
{




   





    class Program
    {


         


        static IEnumerator<int> Testit ()
        {
            for(int i =0; i<10; i++)
            {
                yield return i;
            }
        }


        static IEnumerator<string> Animals()
        {
            yield return "dog";
            yield return "cat";
            yield return "bird";
            yield return "mouse";
            yield return "bear";
        }

        static void Main(string[] args)
        {
            //introduce the IEnum class


            //show how string inhereits the IEnum class
            string[] TestArray = new string[5];

            for (int i = 0; i< 5; i++) 
            {
                TestArray[i] = Convert.ToString(i);
            }




            //set the GetEnumerator of the string to get a handle from the data structure
            var x = TestArray.GetEnumerator();



            //use next to get the first element
            x.MoveNext();


            //use current to show what's in the data structure
            Console.WriteLine(x.Current);


            //use next to get the next element
            x.MoveNext();

            //show a foreach
            foreach(string Current in TestArray) 
            {
                Console.WriteLine(Current);
            }

            //note: it's just using the GetEnumerator function to step through the elements


            //foreach ONLY works with IEnumerted class

            //create an mstack and show how you cant' use foreach
            mstack<int> stack = new mstack<int>();

            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            foreach (int m in stack) 
            {
                Console.WriteLine(m);
            }

            //create a simple example using IEnumator<> return type and yield return (look up notes in enum folder) 
            IEnumerator<int> z;
            int[] arr;
            
            z = Testit();


            z.MoveNext();
            Console.WriteLine(z.Current);
            z.MoveNext();
            Console.WriteLine(z.Current);
            z.MoveNext();
            Console.WriteLine(z.Current);
            z.MoveNext();
            Console.WriteLine(z.Current);
            z.MoveNext();
            Console.WriteLine(z.Current);
            z.MoveNext();
            Console.WriteLine(z.Current);
            z.MoveNext();
            Console.WriteLine(z.Current);





            IEnumerator<string> enumReturn = Animals();

            mstack<int> ms = new mstack<int>();

            ms.Push(10);
            ms.Push(20);
            ms.Push(30);
            ms.Push(40);
            ms.Push(50);
            ms.Push(60);




            foreach (var c in ms)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine();


            //*****INCLASS EXERCISE!!!! Copy mstack into it's own cs file. Import into this project and add it's namespace  ********
            //*****       go into mstack and overload the GetEnumerator() function to enable foreach                        ********



        }
    }
}
