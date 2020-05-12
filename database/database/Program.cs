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
            bool IfEquals = false;int i = 0;
            int IntWhosTheOldest = 0;
            int WhoTheHeckIsEquals1 = 0;
            int WhoTheHeckIsEquals2 = 0;
            string WhoTheUserWantsToDelete = "0";

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
                Console.WriteLine("'delete a person,'");
                Console.WriteLine("'view' everyone, see 'who' is the oldest, ");
                Console.WriteLine("or 'quit'? Keep in mind that 'quit' will end ");
                Console.Write("the program.  ");
                Console.WriteLine("Make sure you type the words that are marked with the ");
                Console.WriteLine("'' symbols. (Press enter when you are done) :");
                WhatTheUserWantsToDo = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine();

                IfReenteredTheDatabaseMainFrame = true;

                if (WhatTheUserWantsToDo == "add")
                {
                    //Asking for person's Information
                    Console.WriteLine("Disclaimer: Read Instructions CAREFULLY:");
                    Console.WriteLine("Okay, what is the person's name?");
                    Console.WriteLine("(Keep in mind that you can do first and last");
                    Console.WriteLine("name, or just first name) :");
                    NameArray[i] = Console.ReadLine();
                    if (NameArray[i] == "0")
                    {                      
                            Console.WriteLine("Sorry, your input is not recognized.");
                            Console.WriteLine("Try again:");
                            NameArray[i] = Console.ReadLine();
                    }
                    Console.WriteLine(" ");

                    Console.WriteLine("Okay, what is the person's age?");
                    Console.WriteLine("2 digits. if it is singular, make sure you put a 0 before it.");
                    Console.WriteLine("Remember, it only takes 2 digits, so once it sees 2 digits, it will be over.");

                    Console.WriteLine(" ");
                    Console.WriteLine("Okay, what is the're Age:");

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

                    //This is to make sure who is the oldest. see line 192 for exact for further Code on this topic
                    if (i != 0)
                    {

                        if (AgeArray[i] > AgeArray[i - 1])
                        {
                            IntWhosTheOldest = i;
                            IfEquals = false;
                        }
                        else if (AgeArray[i -1] == AgeArray[i])
                        {
                            IfEquals = true;
                            WhoTheHeckIsEquals1 = i;
                            WhoTheHeckIsEquals2 = i - 1;
                        }

                    }

                    //This makes sure the program doesn't Overwrite other Information
                    i += 1;

                    //This will stop the program from moving on immediately. see line 184 for same code
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();


                    

                    //Clearing the buffer
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");

                }

                //This will run if the user typed the word 'view'
                if (WhatTheUserWantsToDo == "view")
                {
                    //This makes sure there is Information in the Database
                    if (AgeArray[0] != 0)
                    {
                        //The rest is the same, exept individualy
                        Console.Write(NameArray[0]);
                        Console.Write(", Age ");
                        Console.WriteLine(AgeArray[0]);

                        if (AgeArray[1] != 0)
                        {
                            Console.WriteLine(" ");
                            Console.Write(NameArray[1]);
                            Console.Write(", Age ");
                            Console.WriteLine(AgeArray[1]);
                        }

                        if (AgeArray[2] != 0)
                        {
                            Console.WriteLine(" ");
                            Console.Write(NameArray[2]);
                            Console.Write(", Age ");
                            Console.WriteLine(AgeArray[2]);
                        }

                        if (AgeArray[3] != 0)
                        {
                            Console.WriteLine(" ");
                            Console.Write(NameArray[3]);
                            Console.Write(", Age ");
                            Console.WriteLine(AgeArray[3]);
                        }

                        if (AgeArray[4] != 0)
                        {
                            Console.WriteLine(" ");
                            Console.Write(NameArray[4]);
                            Console.Write(", Age ");
                            Console.WriteLine(AgeArray[4]);
                        }

                        if (AgeArray[5] != 0)
                        {
                            Console.WriteLine(" ");
                            Console.Write(NameArray[5]);
                            Console.Write(", Age ");
                            Console.WriteLine(AgeArray[5]);
                        }

                        if (AgeArray[6] != 0)
                        {
                            Console.WriteLine(" ");
                            Console.Write(NameArray[6]);
                            Console.Write(", Age ");
                            Console.WriteLine(AgeArray[6]);
                        }

                        if (AgeArray[7] != 0)
                        {
                            Console.WriteLine(" ");
                            Console.Write(NameArray[7]);
                            Console.Write(", Age ");
                            Console.WriteLine(AgeArray[7]);
                        }

                        if (AgeArray[8] != 0)
                        {
                            Console.WriteLine(" ");
                            Console.Write(NameArray[8]);
                            Console.Write(", Age ");
                            Console.WriteLine(AgeArray[8]);
                        }

                        if (AgeArray[9] != 0)
                        {
                            Console.WriteLine(" ");
                            Console.Write(NameArray[9]);
                            Console.Write(", Age ");
                            Console.WriteLine(AgeArray[9]);
                        }

                        //This is so that the program will not move on immediately
                        Console.WriteLine("Press any key to continue:");
                        Console.ReadKey();
                    }
                    //This will run if there is no Information inthe Database
                    else
                    {
                        //This prints to the screen that there is no Information in the Database
                        Console.WriteLine("Sorry, there is no Information in the Database.");
                        Console.WriteLine(" ");

                        Console.WriteLine("Press any key to continue:");
                        Console.ReadKey();
                    }

                }

                //This will run if the user typed in the word 'who'
                if (WhatTheUserWantsToDo == "who")
                {
                    if (AgeArray[0] != 0 || AgeArray[1] != 0)
                    {
                        //This will run if the oldest person is equal to another person
                        if (IfEquals == true)
                        {

                            //This printing to the screen the oldest person
                            Console.Write(NameArray[WhoTheHeckIsEquals1]);
                            Console.Write(", age ");
                            Console.Write(AgeArray[WhoTheHeckIsEquals1]);
                            Console.Write(", and ");
                            Console.Write(NameArray[WhoTheHeckIsEquals2]);
                            Console.Write(", age ");
                            Console.Write(AgeArray[WhoTheHeckIsEquals2]);
                            Console.WriteLine(", are both the oldest.");

                            //This is so that the program wont move on Immediately
                            Console.WriteLine("Press any key to continue:");
                            Console.ReadKey();

                        }


                        //This will run if there is someone older than anyone else
                        if (IfEquals == false)
                        {
                            //Printing to the screen who is the oldest
                            Console.Write(NameArray[IntWhosTheOldest]);
                            Console.Write(", age ");
                            Console.Write(AgeArray[IntWhosTheOldest]);
                            Console.WriteLine(", is the oldest.");

                            //Clearing the buffer
                            Console.Write(" ");
                            Console.Write(" ");

                            //This is so that the program wont move on Immediately
                            Console.WriteLine("Press any key to continue:");
                            Console.ReadKey();
                        }

                    }
                    else
                    {
                        Console.WriteLine("Sorry, there is no Information in the Database.");
                        Console.WriteLine(" ");

                        Console.WriteLine("Press any key to continue: ");
                        Console.ReadKey();

                    }

                }

                if (WhatTheUserWantsToDo == "delete")
                {
                    //This makes sure there is Information in the Database
                    if (AgeArray[0] != 0)
                    {
                        //The rest is the same, exept individualy
                        Console.Write(NameArray[0]);
                        Console.Write(", Age ");
                        Console.WriteLine(AgeArray[0]);

                        if (AgeArray[1] != 0)
                        {

                            Console.WriteLine(" ");
                            Console.Write(NameArray[1]);
                            Console.Write(", Age ");
                            Console.WriteLine(AgeArray[1]);
                        }

                        if (AgeArray[2] != 0)
                        {
                            Console.WriteLine(" ");
                            Console.Write(NameArray[2]);
                            Console.Write(", Age ");
                            Console.WriteLine(AgeArray[2]);
                        }

                        if (AgeArray[3] != 0)
                        {
                            Console.WriteLine(" ");
                            Console.Write(NameArray[3]);
                            Console.Write(", Age ");
                            Console.WriteLine(AgeArray[3]);
                        }

                        if (AgeArray[4] != 0)
                        {
                            Console.WriteLine(" ");
                            Console.Write(NameArray[4]);
                            Console.Write(", Age ");
                            Console.WriteLine(AgeArray[4]);
                        }

                        if (AgeArray[5] != 0)
                        {
                            Console.WriteLine(" ");
                            Console.Write(NameArray[5]);
                            Console.Write(", Age ");
                            Console.WriteLine(AgeArray[5]);
                        }

                        if (AgeArray[6] != 0)
                        {
                            Console.WriteLine(" ");
                            Console.Write(NameArray[6]);
                            Console.Write(", Age ");
                            Console.WriteLine(AgeArray[6]);
                        }

                        if (AgeArray[7] != 0)
                        {
                            Console.WriteLine(" ");
                            Console.Write(NameArray[7]);
                            Console.Write(", Age ");
                            Console.WriteLine(AgeArray[7]);
                        }

                        if (AgeArray[8] != 0)
                        {
                            Console.WriteLine(" ");
                            Console.Write(NameArray[8]);
                            Console.Write(", Age ");
                            Console.WriteLine(AgeArray[8]);
                        }

                        if (AgeArray[9] != 0)
                        {
                            Console.WriteLine(" ");
                            Console.Write(NameArray[9]);
                            Console.Write(", Age ");
                            Console.WriteLine(AgeArray[9]);
                        }
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");

                        Console.WriteLine("Of these, who would you like to delete?");
                        Console.WriteLine("Make sure you type the're");
                        Console.WriteLine("Entire name. Fell free to copy and paste:");

                        WhoTheUserWantsToDelete = Console.ReadLine();
                        if (WhoTheUserWantsToDelete == NameArray[0])
                        {
                            AgeArray[0] = 0;
                        }
                        if (WhoTheUserWantsToDelete == NameArray[1])
                        {
                            AgeArray[1] = 0;
                        }
                        if (WhoTheUserWantsToDelete == NameArray[2])
                        {
                            AgeArray[2] = 0;
                        }
                        if (WhoTheUserWantsToDelete == NameArray[3])
                        {
                            AgeArray[3] = 0;
                        }
                        if (WhoTheUserWantsToDelete == NameArray[4])
                        {
                            AgeArray[4] = 0;
                        }
                        if (WhoTheUserWantsToDelete == NameArray[5])
                        {
                            AgeArray[5] = 0;
                        }
                        if (WhoTheUserWantsToDelete == NameArray[6])
                        {
                            AgeArray[6] = 0;
                        }
                        if (WhoTheUserWantsToDelete == NameArray[7])
                        {
                            AgeArray[7] = 0;
                        }
                        if (WhoTheUserWantsToDelete == NameArray[8])
                        {
                            AgeArray[8] = 0;
                        }
                        if (WhoTheUserWantsToDelete == NameArray[9])
                        {
                            AgeArray[9] = 0;
                        }



                        //This is so that the program will not move on immediately
                        Console.WriteLine("Press any key to continue:");
                        Console.ReadKey();
                    }
                    //This will run if there is no Information inthe Database
                    else
                    {
                        //This prints to the screen that there is no Information in the Database
                        Console.WriteLine("Sorry, there is no Information in the Database.");
                        Console.WriteLine(" ");

                        Console.WriteLine("Press any key to continue:");
                        Console.ReadKey();
                    }



                }

                //This will run if the user typed in the word'quit'
                //This will end the program
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
