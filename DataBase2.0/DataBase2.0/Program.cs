//Marshal Fleck
//Fleckm210@gmail.com
//This is an assignment for a database
using System;

namespace DataBase2
{
    class MainClass
    {
        static void AddNamesForTesting(ref string[] names)
        {

            for(int i=0;i<10;i++)
            {
                names[i] = "Name" + (i +1);
            }
        
        }//End AddNamesForTesting

        //Adds a name the Names array
        static void AddName(ref string[] Names)
        {
            int i = 10;
            int NotDuplite = 10;

            //Getting Closest blank name using the search function
            try
            {
                i = Search(Names, (null));
            }
            catch(Exception errorVaraible)
            {
                if(errorVaraible.Message == "Error")
                {
                    
                }
            }

            //If the search function comes up empty
            if (i != 10)
            {

                string NewName = "";
                bool AllIsOkay = false;

                //Asks the user for information
                Console.WriteLine("What is the persons name?");
                NewName = Console.ReadLine();

                //Uses the search function to make sure there is no duplicates
                try
                {
                    NotDuplite = Search(Names, NewName);
                }
                catch (Exception errorVaraible)
                {
                    if (errorVaraible.Message == " ")
                    {

                    }
                }



                if (NotDuplite == 10)
                {
                    AllIsOkay = true;
                }


                if (AllIsOkay)
                {
                    //Displays the added name
                    Console.Write("Okay, ");
                    Console.Write(NewName);
                    Console.WriteLine(" has been added to the DataBase.");

                    Names[i] = NewName;

                    //Clears space
                    Console.WriteLine("");
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("Sorry, that name is already in the database.");
                }
            }
            else
            {
                Console.WriteLine("Sorry, the database is full.");
                Console.WriteLine("Use the delete function to clear some room.");
            }

            //Clears space
            Console.WriteLine("");
            Console.WriteLine("");


        }//End of AddName function

        //Determines the closest blank name
        static int Search(string[] Names, string WhatToSearchFor)
        {
            //Determines the closest answer
            int ClosestNumber = 10;
            for (int i = 9; i > -1; i--)
            {
                if (Names[i] == WhatToSearchFor)
                {
                    ClosestNumber = i;
                }
            }
            

            if (ClosestNumber == 10)
            {
                throw new Exception("Error");
            }

            return ClosestNumber;

        }//End of Search function


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

            //IsName will only be true if there is a name in the database
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

                    //Clears space
                    Console.WriteLine("");
                    Console.WriteLine("");

                    if (Names[WhichNameToDelete - 1] != (null))
                    {
                        IsAnError = false;
                        Names[WhichNameToDelete - 1] = (null);
                    }
                    else
                    {
                        Console.WriteLine("");
                    }
                }
                catch(Exception e)
                {
                    if (e.Message == "Index was outside the bounds of the array.")
                    {
                        Console.WriteLine("Sorry, that number does not exist.");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, it has to be a number.");
                    }

                    //Clears space
                    Console.WriteLine("");
                    Console.WriteLine("");
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
        }//end of delete function

        static void ViewNames(string[] Names, ref bool IsNames)
        {
            //If There is names in the database
            IsNames = false;
            int ActualIndex = 0;

            //Determines if names[index] does not equal nothing
            for (int index = 0; ActualIndex < 10;)
            {
                if (Names[ActualIndex] != (null))
                {
                    Console.Write(index + 1);
                    Console.Write(". ");
                    Console.WriteLine(Names[ActualIndex]);
                    IsNames = true;
                    index++;
                }
                ActualIndex++;
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

        }//end of viewnames function

        static void DisplayOptions()
        {
            Console.WriteLine("You can 'add' a name,");
            Console.WriteLine("You can 'delete' a name,");
            Console.WriteLine("You can 'view' all names,");
            Console.WriteLine("Or you can 'search' for a name.");
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

            //This function init's the names array. Used for testing only
            AddNamesForTesting(ref Names);

            //Introduction to the user
            Console.WriteLine("Hello. This is a database that can store the names");
            Console.WriteLine("for up to 10 people.");
            Console.WriteLine("Make sure to type all lower case, and to hit enter.");

            //Clears space
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            //While the main program is running
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
                    ViewNames(Names, ref IsNames);
                    
                }

                //If the user wants to delete a person
                if (WhatTheUserWantsToDo == "delete")
                {
                    try
                    {
                        Names = Delete(Names, ref IsAnError);
                    }
                    catch(Exception Error)
                    {
                        Console.WriteLine(Error.Message);

                        //Clears space
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
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

                    try
                    {
                        //Calls the search function
                        SearchIndex = Search(Names, WhatToSearchFor);
                    }
                    catch
                    {
                        Console.WriteLine("Sorry, there is no one in the database that has that name.");

                        //Clears space
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");

                        
                    }

                    if (Names[SearchIndex] != (null) )
                    {
                        //Prints the answer
                        Console.Write("The index for that person is :");
                        Console.WriteLine(SearchIndex + 1);

                        //Clears space
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                    }

                }

                //Clears space
                Console.WriteLine(" ");
                Console.WriteLine(" ");
            }
        }//End of main function
    }
}
