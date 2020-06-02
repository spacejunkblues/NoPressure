//Marshal Fleck
//Fleckm210@gmail.com
//This is an assignment for a quiz that uses functions
using System;

namespace Quiz2
{
    class MainClass
    {
        //This is the function that lets the user build there own quiz
        static string[] Q11(ref String[][] Q12, int index)
        {
            int i = 0;

            //Displying which question they are doing
            Console.Write("Question ");
            Console.Write(index + 1);
            Console.WriteLine(". :");

            Q12[index] = new string[5];
            while (i < 4)
            {
                Console.Write(i + 1);
                Console.WriteLine(". :");
                Q12[index][i] = Console.ReadLine();
                i++;
            }
            Console.WriteLine("Press any key to continue:");
            Console.ReadKey();
            
            return Q12[index];
        }

        static string [] DisplayQuiz(ref string[][] Questions)
        {
            int i = 0;
            while (i < 4)
            {
                Console.Write(i + 1);
                Console.WriteLine(". :");
                Console.WriteLine(Questions[0][i]);
                i++;
            }
            Console.WriteLine(" ");

            return Questions[0];
        }

        public static void Main(string[] args)
        {
            //Declaring variables
            string[][] Questions;
            string WhatTheUserWantsToDo;
            bool LoopActive;

            //Init variables
            Questions = new string[4][];
            WhatTheUserWantsToDo = " ";
            LoopActive = true;

            while (LoopActive)
            {

                //Introduction to user
                Console.WriteLine("Hello, this a buildable quiz. would you");
                Console.WriteLine("like to 'do' the preset, or would you like to");
                Console.WriteLine("'build' you own?");
                Console.WriteLine("All lower case, then enter. feel free to copy and paste:");
                WhatTheUserWantsToDo = Console.ReadLine();

                if (WhatTheUserWantsToDo == "build")
                {


                    //Displaying Built Questions
                    int i = 0;
                    for (int Index = 0;Index < 4; Index++)
                    {
                        //Gives the user information on how to build the quiz
                        Console.WriteLine("The first sentence is the question.");
                        Console.WriteLine("The other 4 are the possible answers.");

                        Q11(ref Questions, Index);
                        while (i < 4)
                        {
                            Console.Write(i + 1);
                            Console.WriteLine(". :");
                            Console.WriteLine(Questions[Index][i]);
                            i++;
                        }
                        Console.WriteLine(" ");
                    }


                }

                if (WhatTheUserWantsToDo == "do")
                {
                    int j = 0;
                    while (j < 4)
                    {
                        DisplayQuiz(ref Questions);
                        j++;
                    }
                    
                }
            }
        }
    }
}
