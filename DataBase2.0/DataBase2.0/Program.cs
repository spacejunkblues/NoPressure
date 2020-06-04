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
            bool AllIsOkay = true;

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

                for (int index = 0; index < 10; index++)
                {
                    if (NewName == Names[index])
                    {
                        AllIsOkay = false;
                    }
                }
                if (AllIsOkay)
                {
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

        static string[] Delete(string[] Names, ref bool IsAnError)
        {
            int WhichNameToDelete = 0;
            bool IsAName = false;
            IsAnError = true;

            //Determines if names[index] does not equal nothing
            for (int index = 0; index < 10; index++)
            {
                if (Names[index] != (null))
                {
                    Console.Write(index + 1);
                    Console.Write(". ");
                    Console.WriteLine(Names[index]);
                    IsAName = true;
                }
            }
            if (IsAName)
            {
                //Clears space
                Console.WriteLine(" ");

                //Asks user for which name they would like to delete
                Console.WriteLine("Which person would you like to delete?");
                Console.WriteLine("(Use the index number to the left of the name, then hit enter):");

                try
                {
                    WhichNameToDelete = Convert.ToInt32(Console.ReadLine());
                    IsAnError = false;
                    Names[WhichNameToDelete + 1] = (null);
                }   
                catch (Exception)
                {
                    
                }
            }
            else
            {
                Console.WriteLine("Sorry, there is no names.");
            }

            //Clears space
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            

            return Names;
        }

        static void ViewNames(string[]Names, ref bool IsNames)
        {
            //If There is names in the database
            IsNames = false;

            //Determines if names[index] does not equal nothing
            for (int index = 0; index < 10; index++)
            {
                if (Names[index] != (null))
                {
                    Console.Write(index + 1);
                    Console.Write(". ");
                    Console.WriteLine(Names[index]);
                    IsNames = true;
                }
            }

            //Clears space
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            if (IsNames)
            {
                //Asks the user if they want to continue
                Console.WriteLine("Press any key to continue:");
                Console.ReadKey();
            }
          
        }


            //Start of our program
        public static void Main(string[] args)
        {
            //Declaring variables
            string[] Names;
            string WhatTheUserWantsToDo;
            string WhatToSearchFor;
            bool MainMenuActive;
            bool IsAnError;
            bool IsNames;
            int SearchIndex;

            //Init variables
            Names = new string[10];
            MainMenuActive = true;
            IsAnError = true;
            IsNames = false;
            WhatTheUserWantsToDo = " ";
            WhatToSearchFor = " ";
            SearchIndex = 0;

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

                //If the user wants to delete a person
                if (WhatTheUserWantsToDo == "delete")
                {
                    while (true)
                    {
                        Names = Delete(Names, ref IsAnError);
                        if (IsAnError)
                        {
                            Console.WriteLine("Sorry, you have to type a number.");
                        }
                        else
                        {
                            break;
                        }
                    }
                    
                }

                //If the user wants to view all the names
                if (WhatTheUserWantsToDo == "view")
                {
                      ViewNames(Names, ref IsNames);
                     if (!IsNames)
                     {
                        Console.WriteLine("Sorry, there is no names in the database.");

                        //Clears space
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");

                        //ASks the user if he wants to move on
                        Console.WriteLine("Press any key to continue:");
                        Console.ReadKey();

                            
                     }
                }

                //Calls the search function if the user typed "search"
                if (WhatTheUserWantsToDo == "search")
                {
                        //Asks the user for information on who to search for
                        Console.WriteLine("Who would you like to search for?");
                        WhatToSearchFor = Console.ReadLine();

                        //Clears space
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");


                    //Calls the search function
                    SearchIndex = Search(Names, WhatToSearchFor);

                    if (Names[SearchIndex] != (null) )
                    {
                        //Prints the answer
                        Console.Write("The index for that person is :");
                        Console.WriteLine(SearchIndex + 1);

                        //Clears space
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, there is no one in the database that has that name. ");
                    }

                }

                //Clears space
                Console.WriteLine(" ");
                Console.WriteLine(" ");
            }
        }
    }
}
