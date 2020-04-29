//Marshal Fleck
//fleckm210@gmail.com
//this is an assignment for a Calculator
using System;

namespace MadLib
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //writing all the variables using the string datatype
            // 3 verbs, 3 nouns, and 2 adjectives
            string verb1;
            string verb2;
            string verb3;
            string noun1;
            string noun2;
            string noun3;
            string adjective1;
            string adjective2;
            string adjective3;
            string verb4;
            string adverb;

            // starting intros
            Console.WriteLine("This a MadLib. I am going to ask for 3 nouns, 2 adjectives, and 3 verbs.");
            Console.WriteLine("Type the word when I ask for it, then press Enter: ");

            // asking for verbs
            Console.Write("singular verb:");
            verb1 = Console.ReadLine();
            Console.Write("singular verb:");
            verb2 = Console.ReadLine();
            Console.Write("singular verb:");
            verb3 = Console.ReadLine();
            Console.Write("singular verb:");
            verb4 = Console.ReadLine();

            // asking for nouns
            Console.Write(" subject noun:");
            noun1 = Console.ReadLine();
            Console.Write(" place noun:");
            noun2 = Console.ReadLine();
            Console.Write("noun:");
            noun3 = Console.ReadLine();

            // asking for adjectives and an adverb
            Console.Write("adjective:");
            adjective1 = Console.ReadLine();
            Console.Write("adjective:");
            adjective2 = Console.ReadLine();
            Console.Write("adjective:");
            adjective3 = Console.ReadLine();
            Console.Write("adverb:");
            adverb = Console.ReadLine();

            // writing to the screen
            Console.Write(noun1);
            Console.Write(" was ");
            Console.Write(verb1);
            Console.Write("ing down the ");
            Console.Write(noun2);
            Console.Write(" when he very ");
            Console.Write(adverb);
            Console.Write(" ");
            Console.Write(verb2);
            Console.Write(" across a ");
            Console.Write(noun3);
            Console.Write(".");
            Console.Write(" then he very ");
            Console.Write(adjective1);
            Console.Write("ly ");
            Console.Write(verb3);
            Console.Write(" for ");
            Console.Write(verb4);
            Console.Write(". this was ");
            Console.Write(adjective2);
            Console.Write(" becuase ");
            Console.Write(noun1);
            Console.Write(" was ");
            Console.Write(adjective3);

        }
    }
}
