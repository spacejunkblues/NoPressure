using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Xml;

namespace InClassLesson20_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a List<>
            //note that it's a generic class
            List<int> mylist = new List<int>();

            //note that the object contains GetEnumerator


            //Add to the list
            mylist.Add(10);
            mylist.Add(20);
            mylist.Add(30);
            mylist.Add(40);

            //print the list
            //note that it doesn't print directly with writeline (to be expected)

            Console.WriteLine(mylist.ToArray());

            //show how the [] operator was overloaded to work with lists
            Console.WriteLine(mylist[0]);

            //use with foreach
            foreach (var c in mylist)
                Console.WriteLine(c);

            //note all the other methods like ToArray, Find, etc


            //Remove first occurance or RemoveAt
            if(mylist.Remove(20))
                Console.WriteLine("20 removed");
            else
                Console.WriteLine("Couldn't find 20");

            mylist.RemoveAt(0);


            //Create a Dictionary<,>
            Dictionary<int, string> dict = new Dictionary<int, string>();



            //demo key value pairs with ID's and names
            dict.Add(10, "uncle");
            dict.Add(57, "march");
            dict.Add(11, "uncle");

            //show how dict overloaded the index to be used with key's
            Console.WriteLine(dict[10]);

            //can still print one at a time with foreach
            //notice how each element in the data structure is a key,value pair.
            //can use .Key or .Value

            foreach (var c in dict)
                Console.WriteLine(c.Value);



            //can use ElementAt to get index in the order that they were entered
            KeyValuePair<int,string> kvp = dict.ElementAt(1);

            Console.WriteLine(kvp.Value);
      
        }
    }
}
