//Marshal Fleck
//Fleckm210@gmail.com
//This is an assignment for a database
using System;

namespace DataBase2
{
    class MainClass
    {
        //Adds a name the Names array
        static void AddName(ref string[]Names)
        {
            //Getting Closest blank name using the search function
            int i = 0;
            i = Search(Names, "");
            string NewName = "";
            bool AlreadyInDataBase = false;

            while (true)
            {
                //Asking user for Information on the added person
                Console.WriteLine("What is the persons name?");
                Console.WriteLine("Remember, you can do First and last name,");
                Console.WriteLine("Or just first name. Hit enter when you are done:");
                NewName = Console.ReadLine();

                //Clears space
                Console.WriteLine("");
                Console.WriteLine("");

                //Makes sure that the new name is not a duplicate
                for (int Index = 0; Index < 10; Index++)
                {
                    if (NewName == Names[Index])
                    {
                        //Clears space
                        Console.WriteLine("");
                        Console.WriteLine("");

                        Console.WriteLine("Sorry, that name is already in the database.");
                        Console.WriteLine("Try Again.");

                        //Clears space
                        Console.WriteLine("");
                        Console.WriteLine("");

                        Console.WriteLine("Press any key to continue:");
                        Console.ReadKey();

                        //Telling the code to repeat
                        AlreadyInDataBase = true;

                        break;
                    }
                }

                //Tells the code to break from the loop if AlreadyInDataBase = false
                if (!AlreadyInDataBase)
                {
                    Names[i] = NewName;
                    break;
                }
            }


            //Displays the added name
            Console.Write("Okay, ");
            Console.Write(Names[i]);
            Console.WriteLine(" has been added to the DataBase.");

            //Clears space
            Console.WriteLine("");
            Console.WriteLine("");

        }

        //This is the function that displays the users options
        static void DisplayOptions()
        {
            //Tells the user what they can do
            Console.WriteLine("You can 'add' a person.");
            Console.WriteLine("You can 'delete' a person.");
            Console.WriteLine("You can 'view' all names.");
            Console.WriteLine("Or you can 'search' for a person:");
        }

        //Determines the closest blank name
        static int Search(string[]Names, string WhatToSearchFor)
        {
            int ClosestNumber = 0;
            for (int i = 9;i < -1; i--)
            {
                if (Names[i] == WhatToSearchFor)
                {
                    ClosestNumber = i;
                }
            }



            return ClosestNumber;
        }

        static string[] Delete(string[] Names)
        {
            int WhichNameToDelete = 0;

            //Asking the user which name to delete
            for (int i = 0;i > 10; i++)
            {
                Console.Write(i + 1);
                Console.Write(". ");
                Console.WriteLine(Names[i]);
            }

            //Asks user for which name they would like to delete
            Console.WriteLine("Which person would you like to delete?");
            Console.WriteLine("(Use the index number to the left of the name, then hit enter):");

            try
            {
                WhichNameToDelete = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {

            }

            return Names;
        }






        //Start of our program
        public static void Main(string[] args)
        {
            //Declaring variables
            string[] Names;
            string IfRunTheProgramAgain;
            string WhatTheUserWantsToDo;
            bool MainMenuActive;

            //Init variables
            Names = new string[10];
            MainMenuActive = true;
            IfRunTheProgramAgain = " ";
            WhatTheUserWantsToDo = " ";

            //Introduction to the user
            Console.WriteLine("Hello. This is a databse that can store the names");
            Console.WriteLine("for up to 10 people.");
            Console.WriteLine("Make sure to type all lower case, and to hit enter.");

            //Clears space
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            //While the main program is runninf
            while (MainMenuActive)
            {
                //Calls The function that displays options
                DisplayOptions();
                WhatTheUserWantsToDo = Console.ReadLine();

                //Clears space
                Console.WriteLine(" ");
                Console.WriteLine(" ");

                //Determines what the user wants to do
                if (WhatTheUserWantsToDo == "add")
                {
                    //Calls the function that adds a name to the Names array
                    AddName(ref Names);
                }

                if (WhatTheUserWantsToDo == "delete")
                {

                }




                while(true)
                {
                    //Asking the user if he would like to run the program again
                    Console.WriteLine("Would you like to run the program again?");
                    Console.WriteLine("'yes' or 'no' :");
                    IfRunTheProgramAgain = Console.ReadLine();

                    //Determining if the user wants to run the program again
                    //If User types 'no'
                    if (IfRunTheProgramAgain == "no")
                    {
                        MainMenuActive = false;
                        break;
                    }

                    //If User types 'yes'
                    //This is so that i can error check if the user didnt type the right word
                    else if (IfRunTheProgramAgain == "yes")
                    {
                        break;
                    }

                    //This is error checking the user input
                    else
                    {
                        Console.WriteLine("Sorry, you have to type 'yes' or 'no'.");
                        Console.WriteLine("Press any key to continue:");
                        Console.ReadKey();
                    }
                }

            }
        }
    }
}
