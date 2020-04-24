//marshal fleck
//april 22 2020
//
//this an assignment given to 
//me by the greatest uncle on the face of planet earth. maybe even the galaxy. theres no telling, really.
//
//
using System;

namespace lesson3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //declaring varaibles
            int username1;
            int username2;
            int username3;
            int username4;
            int username5;  //this is the users fith letter in their name.
            int userlastname1;
            int userlastname2;
            int userlastname3;
            int userlastname4;
            int userlastname5;

            //Init
            username1 = 0;
            username2 = 0;
            username3 = 0;
            username4 = 0;
            username5 = 0;
            userlastname1 = 0;
            userlastname2 = 0;
            userlastname3 = 0;
            userlastname4 = 0;
            userlastname5 = 0;


            char newline;

            newline = (char)104;
            newline = (char)10;
            
            //using an escape character to print "\n" to the screen
            Console.WriteLine("\\n");


            //Get the users first name
            Console.WriteLine("what is your name? (type exactly 5 letters)");
            username1 = Console.Read();
            username2 = Console.Read();
            username3 = Console.Read();
            username4 = Console.Read();
            username5 = Console.Read();

            //clear the buffer
            Console.Read(); //this one will clear the 13
            Console.Read(); //this one will clear the 10

            //Greet the user
            Console.WriteLine(" ");
            Console.Write((char)username1);
            Console.Write((char)username2);
            Console.Write((char)username3);
            Console.Write((char)username4);
            Console.Write((char)username5);
            Console.Write(",");
            Console.Write("huh?");
            Console.Write("    hmmmm,");
            Console.WriteLine(" i think i knew somebody with that name.");
            Console.Write(" fascinating,");
            Console.Write(" isn't it?");
            Console.WriteLine(" ");


            //Get users lastname
            Console.WriteLine("what is your last name?");
            userlastname1 = Console.Read();
            userlastname2 = Console.Read();
            userlastname3 = Console.Read();
            userlastname4 = Console.Read();
            userlastname5 = Console.Read();

            Console.WriteLine(" ");

            Console.Write(" so ");
            Console.Write((char)username1);
            Console.Write((char)username2);
            Console.Write((char)username3);
            Console.Write((char)username4);
            Console.Write((char)username5);
            Console.Write(" ");
            Console.Write((char)userlastname1);
            Console.Write((char)userlastname2);
            Console.Write((char)userlastname3);
            Console.Write((char)userlastname4);
            Console.Write((char)userlastname5);
            Console.Write(" is your full name, huh?");


            Console.Write("\nPress any ke\ny to continue");
            Console.ReadKey();
        }
    }
}
