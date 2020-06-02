//Marshal Fleck
//Fleckm210@gmail.com
//This is an assignment for a quiz that uses functions
using System;

namespace Quiz2
{
    class MainClass
    {
        static string[][]SetQuiz(ref string[][] QuizArray, ref int[]answers)
        {
            QuizArray = new string[5][];

            QuizArray[0] = new string[5];
            QuizArray[1] = new string[5];
            QuizArray[2] = new string[5];
            QuizArray[3] = new string[5];
            QuizArray[4] = new string[5];

            QuizArray[0][0] =  "What is my name";
            QuizArray[0][1] =  "1. Marshal";
            QuizArray[0][2] =  "2. Henry";
            QuizArray[0][3] =  "3. Richard";
            QuizArray[0][4] =  "4. Your Name";
            answers[0] = 1;

            QuizArray[1][0] =  "What is the mcdonalds motto?";
            QuizArray[1][1] =  "1. Im Hating it";
            QuizArray[1][2] =  "2. Im loving it";
            QuizArray[1][3] =  "3. Why is there even a motto?";
            QuizArray[1][4] =  "4. I hate Mcdonalds";
            answers[1] = 3;

            return QuizArray;
        }

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

        static string [] DisplayQuiz(ref string[][] Questions, ref int[] ThereAnswers, ref int WhichQuestion)
        {
            int i = 0;
            while (i < 4)
            {
                Console.WriteLine(Questions[WhichQuestion][i]);
                i++;
            }
            Console.WriteLine(" ");
            ThereAnswers[i] = Convert.ToInt32(Console.ReadLine());

            return Questions[0];
        }

        public static void Main(string[] args)
        {
            //Declaring variables
            string[][] Questions;
            string WhatTheUserWantsToDo;
            bool LoopActive;
            int[] Answers;
            int[] ThereAnswers;

            //Init variables
            Questions = new string[5][];
            WhatTheUserWantsToDo = " ";
            LoopActive = true;
            Answers = new int[5];
            ThereAnswers = new int[5];

            SetQuiz(ref Questions, ref Answers);

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

                        //Asking which statement they would like to be the answer
                        Console.WriteLine("Which Possible answer would you like to be the answer?");
                        
                            Answers[i] =  Convert.ToInt32(Console.ReadLine());
                        

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
                            DisplayQuiz(ref Questions, ref ThereAnswers,ref j);
                            j++;
                        }

                    }
            }
        }
    }
}
