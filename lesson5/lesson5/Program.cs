//Marshal Fleck
//Fleckm210@gmail.com
//this is an assignment
using System;

namespace lesson5
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Declaring char (character) variables for quiz
            char q1;
            char q2;
            char q3;
            char q4;
            char q5;
            int gradescore;
            string ifwanttoseeanswers; 

            //Init variables
            q1 = ('a');
            q2 = ('a');
            q3 = ('a');
            q4 = ('a');
            q4 = ('a');
            gradescore = 0;

            // introdution to the user
            Console.WriteLine("This is a quiz on American history. I will ask you a question, then you will");
            Console.WriteLine(" write the letter associated with the answer. Hit enter wen you are done.");
            Console.WriteLine("Make sure you answer in capital letters.");
            Console.WriteLine("(hit enter when you are ready:)");
            Console.ReadKey();

            // Asking the first question
            Console.WriteLine("The first President of the United States was:");
            Console.WriteLine("A. Herbert Hoover");
            Console.WriteLine("B. George Wahington");
            Console.WriteLine("C. Mickey Mouse");
            Console.Write("Your answer:");
            q1 = (Char)Console.Read();
            Console.Read(); 
            Console.Read();  

            //Defining the end score
            if (q1 == (char)142)
            {
                gradescore = gradescore + 1;
            }
            else
            {
                gradescore += 2;
            }

            //Setting up for the second question
            Console.WriteLine(" ");
            Console.WriteLine("Press enter to continue:");
            Console.ReadKey();

            //Asking the second question
            Console.WriteLine("Which state was the first state in the United states:");
            Console.WriteLine("A. Maine");
            Console.WriteLine("B. Virginia");
            Console.WriteLine("C. Deleware");
            Console.Write("Your answer:");
            q2 = (Char)Console.Read();
            Console.Read(); 
            Console.Read(); 

            //Defining the end score
            if (q2 == (char)143)
            {
                gradescore += 1;
            }
            else
            {
                gradescore += 2;
            }

            //Setting up for the third question
            Console.WriteLine(" ");
            Console.WriteLine("Press enter to continue:");
            Console.ReadKey();

            //Asking the third question
            Console.WriteLine("Finish the statement: ");
            Console.WriteLine("'Give me Liberty of give me ");
            Console.WriteLine("A. Chick Fil A");
            Console.WriteLine("B. A Hamberger");
            Console.WriteLine("C. Death");
            Console.Write("Your answer:");
            q3 = (Char)Console.Read();
            Console.Read(); 
            Console.Read(); 

            //Defining the end score
            if (q3 == (char)143)
            {
                gradescore += 1;
            }
            else
            {
                gradescore += 2;
            }

            //Setting up for the fourth question
            Console.WriteLine(" ");
            Console.WriteLine("Press enter to continue:");
            Console.ReadKey();

            //Asking the fourth question
            Console.WriteLine("Who wrote the Declaration of Independance: ");
            Console.WriteLine("A. Thomas Jefferson");
            Console.WriteLine("B. Anders Hejlsberg");
            Console.WriteLine("C. King George");
            Console.Write("Your answer:");
            q4 = (Char)Console.Read();
            Console.Read(); 
            Console.Read(); 

            //Defining the end score
            if (q4 == (char)141)
            {
                gradescore += 1;
            }
            else
            {
                gradescore += 2;
            }

            //Setting up for the fith question
            Console.WriteLine(" ");
            Console.WriteLine("Press enter to continue:");
            Console.ReadKey();

            //Asking the fith question
            Console.WriteLine("How many planets are in our solar system:");
            Console.WriteLine("A. 0");
            Console.WriteLine("B. 8");
            Console.WriteLine("C. 50");
            Console.Write("Your answer:");
            q5 = (Char)Console.Read();
            Console.Read(); 
            Console.Read(); 

            //Clearing the buffer
            Console.WriteLine(" ");

            //Defining the end score
            if (q5 == (char)142)
            {
                gradescore += 1;
            }
            else
            {
                gradescore += 2;
            }

            if (gradescore == 5)
            {
                Console.WriteLine("Congratulations!! You got an A!!");
                Console.WriteLine("You got 100% correct!!");
            }
            else if (gradescore == 6)
            {
                Console.WriteLine("Not bad you got a B.");
                Console.WriteLine("You got 80% correct. Not bad.");
            }           
            else if (gradescore == 7)
            {
                Console.WriteLine("Better luck next time. You got a c.");
                Console.WriteLine("You got 60% correct. Hey, it's better than an F. ");
            }
            else if (gradescore <= 8)
            {
                Console.WriteLine("Sorry, you got an F.");
                xConsole.WriteLine("You got lower than 60% correct. Better luck next time.");
            }
          
            //Asking the user if they want the answers to the test
            Console.WriteLine("Would you like to see the answers? (lower case yes or no, then enter):"); 
            ifwanttoseeanswers = Console.Readline();
            if(ifwanttoseeanswers = yes)
            {
             
             //Showing the answers         
             Console.WriteLine("How many planets are in our solar system:");
             Console.WriteLine("NO A. 0");
             Console.WriteLine("YES B. 8");
             Console.WriteLine("NO C. 50");
             Console.Write("Your answer:");
             Console.WriteLine(q5);

             Console.WriteLine(" ");
             Console.WriteLine("Press enter to continue:");
             Console.ReadKey();

             Console.WriteLine("Who wrote the Declaration of Independance: ");
             Console.WriteLine("YES A. Thomas Jefferson");
             Console.WriteLine("NO B. Anders Hejlsberg");
             Console.WriteLine("NO C. King George");
             Console.Write("Your answer was: ");
             Console.WriteLine(q4);

             Console.WriteLine(" ");
             Console.WriteLine("Press enter to continue:");
             Console.ReadKey();

             Console.WriteLine("Finish the statement: ");
             Console.WriteLine("'Give me Liberty of give me ");
             Console.WriteLine("NO A. Chick Fil A");
             Console.WriteLine("NO B. A Hamberger");
             Console.WriteLine("YES C. Death");
             Console.Write("Your answer:");
             Console.WriteLine(q3);

             Console.WriteLine(" ");
             Console.WriteLine("Press enter to continue:");
             Console.ReadKey();

             Console.WriteLine("Which state was the first state in the United states:");
             Console.WriteLine("NO A. Maine");
             Console.WriteLine("NO B. Virginia");
             Console.WriteLine("YES C. Deleware");
             Console.Write("Your answer:");
             Console.WriteLine(q2);

             Console.WriteLine(" ");
             Console.WriteLine("Press enter to continue:");
             Console.ReadKey();

             Console.WriteLine("The first President of the United States was:");
             Console.WriteLine("A. Herbert Hoover");
             Console.WriteLine("B. George Wahington");
             Console.WriteLine("C. Mickey Mouse");
             Console.Write("Your answer:");
             Console.WriteLine(q1);

            }
        
        
        }
    }
}
