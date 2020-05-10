//Marshal Fleck
//Fleckm210@gmail.com
//This is an assignment for a database that holds name and age
using System;

namespace database
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Declaring and Init database variables
            int[] AgeArray = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
            string[] NameArray = { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0"};
            string WhatTheUserWantsToDo = "0";
            bool LoopActivated = true;
            bool IfReenteredTheDatabaseMainFrame = false;
            int i = 0;
            int WhosTheOldest = 0;
            int LoopIndex = 0;

            //introduction to the user;
            Console.WriteLine("Hello, this is a database that can store");
            Console.WriteLine("Age and Name for up to 10 people.");

            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("You have entered the DataBase loop.");
            while(LoopActivated == true)
            {
                if (IfReenteredTheDatabaseMainFrame == true)
                {
                    Console.WriteLine("You have reentered the database mainframe.");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                }

                //Asking the user what they want to do
                Console.WriteLine("Would you like to (all Lower case)'add' a person, ");
                Console.WriteLine("'view' everyone, 'who' is the oldest, ");
                Console.WriteLine("or 'quit'? Keep in mind that 'quit' will end ");
                Console.Write("the program. :");
                WhatTheUserWantsToDo = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine();

                IfReenteredTheDatabaseMainFrame = true;

                if (WhatTheUserWantsToDo == "add")
                {
                    //Asking for person's Information
                    Console.WriteLine("Okay, what is the person's name?");
                    Console.WriteLine("(Keep in mind that you kan do first and last");
                    Console.WriteLine("name, or just first name) :");
                    NameArray[i] = Console.ReadLine();
                    if (NameArray[i] == "0")
                    {
                        
                        
                            Console.WriteLine("Sorry, your input is not recognized.");
                            Console.WriteLine("Try again:");
                            NameArray[i] = Console.ReadLine();
                         
                    }
                    Console.WriteLine(" ");

                    Console.WriteLine("Okay, what is the person's age? (2 digits. if it is singular, make sure you put a 0 before it):");
                    AgeArray[i] = Console.Read();
                    AgeArray[i] -= 48; 
                    AgeArray[i] *= 10;
                    AgeArray[i] += Console.Read();
                    AgeArray[i] -= 48;

                    //If the user enters "0"
                    if (AgeArray[i] < 00)
                    {
                        Console.WriteLine("Sorry, a person's age cannot be 0.");
                        Console.WriteLine("Try Again:");
                        AgeArray[i] = Console.Read();
                        AgeArray[i] -= 48;
                        AgeArray[i] *= 10;
                        AgeArray[i] = Console.Read();
                        Console.Read();
                        Console.Read();
                        AgeArray[i] -= 48;
                    }

                    Console.WriteLine(" ");

                    Console.Write("Okay, ");
                    Console.Write(NameArray[i]);
                    Console.Write(", Age ");
                    Console.Write(AgeArray[i]);
                    Console.WriteLine(", has added to the database.");

                    i += 1;

                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();

                    //Clearing the buffer
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");

                }
                if (WhatTheUserWantsToDo == "view")
                {
                    Console.Write(NameArray[0]);
                    Console.Write(", Age ");
                    Console.WriteLine(AgeArray[0]);


                    Console.Write(NameArray[1]);
                    Console.Write(", Age ");
                    Console.WriteLine(AgeArray[1]);

                    Console.Write(NameArray[2]);
                    Console.Write(", Age ");
                    Console.WriteLine(AgeArray[2]);

                    Console.Write(NameArray[3]);
                    Console.Write(", Age ");
                    Console.WriteLine(AgeArray[3]);

                    Console.Write(NameArray[4]);
                    Console.Write(", Age ");
                    Console.WriteLine(AgeArray[4]);

                    Console.Write(NameArray[5]);
                    Console.Write(", Age ");
                    Console.WriteLine(AgeArray[5]);

                    Console.Write(NameArray[6]);
                    Console.Write(", Age ");
                    Console.WriteLine(AgeArray[6]);

                    Console.Write(NameArray[7]);
                    Console.Write(", Age ");
                    Console.WriteLine(AgeArray[7]);

                    Console.Write(NameArray[8]);
                    Console.Write(", Age ");
                    Console.WriteLine(AgeArray[8]);

                    Console.Write(NameArray[9]);
                    Console.Write(", Age ");
                    Console.WriteLine(AgeArray[9]);

                    Console.WriteLine("Press any key to continue:");
                    Console.ReadKey();

                }

                if (WhatTheUserWantsToDo == "who")
                {
                    for (LoopIndex = 0; LoopIndex < 10; LoopIndex += 1)
                    {
                        if (LoopIndex < 10)
                        {
                            if (AgeArray[LoopIndex] < AgeArray[LoopIndex + 1])
                            {
                                WhosTheOldest = LoopIndex;
                            }
                        }
                    }

                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                }

                if (WhatTheUserWantsToDo == "quit")
                {
                    LoopActivated = false;
                }






                //Clearing for next section
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                

            }

        }
    }
}
