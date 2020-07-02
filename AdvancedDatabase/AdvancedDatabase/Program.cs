//This is an assignment for a program that can store names
using System;

namespace AdvancedDatabase
{
    class MainClass
    {
        //AddName adds a name to the array
        public static string[] AddName(string[]OriginalArray)
        {
            //Declare i for indexing
            int i;

            //Bool flagging search loop
            bool blankfound = false;

            //Determines the open spot for adding a name
            for(i = 0; i < OriginalArray.Length - 1; i++)
            {
                if (OriginalArray[i] == null)
                {
                    blankfound = true;
                    break;
                }
            }

            //Clears space
            Console.WriteLine();
            Console.WriteLine();

            //Asks the user for the new persons info
            Console.WriteLine("What is the persons name?");

            //Takes the input from the user and stores into a placeholder
            string PlaceHolder = Console.ReadLine();

            //Determines if the user entered nothing
            if (PlaceHolder == "")
            {
                Console.WriteLine("Sorry, you cannot give nothing as a name.");
                Console.WriteLine("Your person will not be entered into the database");

                //Wipe the incorrect from the database
                PlaceHolder = null;
            }
            else if(blankfound)
            {
                //Displays the entered name to the user
                Console.WriteLine("Name " + PlaceHolder + " has been entered into the database.");

                

                //Enters the Name into the database
                OriginalArray[i] = PlaceHolder;
            }
                
            //Returns the modified array
            return OriginalArray;
        }

        //Save saves the array to a file
        public static void Save(string[]SavedArray)
        {
            //Creates path for saving
            string Path = @"/Users/maggiefleck/Desktop/NoPressure/Test.txt";

            for (int i = 0; i < SavedArray.Length; i++)
            {
                if (SavedArray[i] != null)
                {
                    //Saves names to a file inside the program directory
                    System.IO.File.AppendAllText(Path, SavedArray[i] + (char) 10);
                }

            }
        }

        //Load loads a name from the file
        public static string[] Load(string[] OriginalArray)
        {
            //Creates path for loading
            string Path = @"/Users/maggiefleck/Desktop/NoPressure/Test.txt";

            //Loads a name from the array file
            for (int i = 0; i < 10; i++)
            {
                OriginalArray = System.IO.File.ReadAllLines(Path);
            }

            //Returns the modified array
            return OriginalArray;
        }

        //View displays all names
        public static void View(string[]ViewedArray)
        {
            //Clears space
            Console.WriteLine();
            Console.WriteLine();

            //Bool flagging if there is no names
            bool IsNames = false;

            //Displays names in the database
            for (int i = 0; i < ViewedArray.Length; i++)
            {
                //if the name is not blank
                if (ViewedArray[i] != null)
                {
                    //Displays not blank name
                    Console.WriteLine((i + 1) + "." + ViewedArray[i]);

                    //there is a name if this runs
                    IsNames = true;
                }
            }

            //checking bool flag
            if (!IsNames)
            {
                Console.WriteLine("Sorry, there is no names in the database.");
                Console.WriteLine("Try loading some names if you are not seeing your names.");
            }

            //Clears space
            Console.WriteLine();
            Console.WriteLine();
        }

        public static void Main(string[] args)
        {
            //Declare Variables
            string[] Names;
            string WhatTheUserWantsToDo;
            bool StillRunning;

            //Init variables
            Names = new string[10];
            StillRunning = true;
            WhatTheUserWantsToDo = " ";

            //Introduction to the user
            Console.WriteLine("Hello, this a database that can store and save names.");

            //Clears space
            Console.WriteLine();
            Console.WriteLine();


            //While StillRunning is true
            while (StillRunning)
            {
                //display menu
                Console.WriteLine("You can 'add' a name,");
                Console.WriteLine("You can 'save' a name,");
                Console.WriteLine("You can 'load' a name,");
                Console.WriteLine("or you can 'view' all names.");
                Console.WriteLine("All lower case, then hit enter:");

                //Takes input from the user
                WhatTheUserWantsToDo = Console.ReadLine();

                //Determine what the user wants to do
                if (WhatTheUserWantsToDo == "add")
                {
                    AddName(Names);
                }
                else if(WhatTheUserWantsToDo == "save")
                {
                    Save(Names);
                }
                else if(WhatTheUserWantsToDo == "load")
                {
                    Names = Load(Names);
                }
                else if (WhatTheUserWantsToDo == "view")
                {
                    View(Names);
                }

                //If the user put in mispelled or incorrect input
                else
                {
                    //tells the user there input is incorrect
                    Console.WriteLine("Sorry, that is incorrect.");
                    Console.WriteLine("Press any key to continue:");
                    Console.ReadKey();
                }

                //Clears space
                Console.WriteLine();
                Console.WriteLine();
            }

        }
    }
}
