using System;

namespace InClassLesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            //decalare varibles
            int x;
            bool bl;
            int grade;
            char lettergrade;

            //init
            x = 5;
            bl = x < 10;
            grade = 0;
            lettergrade = 'F';

            if (x < 10) //must be a bool
            {
                Console.Write("1. X<10 is true. x is ");
                Console.WriteLine(x);
            }
            if (bl) //must be a bool
            {
                Console.Write("2. X<10 is true. x is ");
                Console.WriteLine(x);
            }



            x = 12;
            if (x < 10)
            {
                Console.Write("3. X<10 is true. x is ");
                Console.WriteLine(x);
            }


            //if and else
            x = 12;
            if (x < 10)
            {
                Console.Write("3. X<10 is true. x is ");
                Console.WriteLine(x);
            }
            else
            {
                Console.Write("4. X<10 is false. x is ");
                Console.WriteLine(x);
            }

            //nested if grade example
            grade = 0;

            if (grade >= 90)
            {
                lettergrade = 'A';
            }
            else
            {
                if(grade >= 80)
                {
                    lettergrade = 'B';
                }
                else
                {
                    if (grade >= 70)
                    {
                        lettergrade = 'C';
                    }
                    else
                    {
                        if (grade >= 60)
                        {
                            lettergrade = 'D';
                        }
                        else
                        {
                            lettergrade = 'F';
                        }

                    }

                }
            }

            //same exact thing, but now lets use elseif to make it cleaner
            grade = 90;
            lettergrade = 'N';

            if (grade >= 90)
            {
                lettergrade = 'A';
            }
            else if (grade >= 80)
            {
                lettergrade = 'B';
            }
            else if (grade >= 70)
            {
                lettergrade = 'C';
            }
            else if (grade >= 60)
            {
                lettergrade = 'D';
            }
            else
            {
                lettergrade = 'F';
            }

            //if's with no elses. Can they do the same thing?            
            grade = 65;
            lettergrade = 'N';
            bl = false;

            if (grade >= 90)
            {
                lettergrade = 'A';
                bl = true;
            }
            if (grade >= 80 && bl == false)
            {                             
                lettergrade = 'B';
                bl = true;
            }
            if (grade >= 70 && bl == false)
            {
                lettergrade = 'C';
                bl = true;
            }
            if (grade >= 60 && bl == false)
            {
                lettergrade = 'D';
                bl = true;
            }
            if (grade < 60 && !bl)
            {
                lettergrade = 'F';
                bl = true;
            }

            //if's with no elses. not extra varaibles. Can they do the same thing?            
            grade = 65;
            lettergrade = 'N';

            if (grade >= 90)
            {
                lettergrade = 'A';
            }
            if (grade >= 80 && grade < 90)
            {
                lettergrade = 'B';
            }
            if (grade >= 70 && grade < 80)
            {
                lettergrade = 'C';
            }
            if (grade >= 60 && grade < 70)
            {
                lettergrade = 'D';
            }
            if (grade < 60)
            {
                lettergrade = 'F';
            }

            //if's with no elses. not extra varaibles. no logical Can they do the same thing?            
            grade = 90;
            lettergrade = 'N';
           
            if (grade < 60)
            {
                lettergrade = 'F';
            }
            if (grade >= 60)
            {
                lettergrade = 'D';
            }
            if (grade >= 70)
            {
                lettergrade = 'C';
            }
            if (grade >= 80 )
            {
                lettergrade = 'B';
            }
            if (grade >= 90)
            {
                lettergrade = 'A';
            }
            
           //switch  this is the same thing as doing elseif's (sorta)

            switch (lettergrade)
            {
                case 'A':
                    Console.WriteLine("You got an A. You got honor rolled.");

                    break;

                case 'B':
                    Console.WriteLine("You got an B. Yeah, that's alright");
                    break;

                case 'C':
                    Console.WriteLine("You got an C");
                    break;

                case 'D':
                    Console.WriteLine("You got an D");
                    break;

                case 'F':
                    Console.WriteLine("You got an F. That really sucks.");
                    break;

                default:
                    Console.WriteLine("You got nothing. No grade found");
                    break;

            }//end of switch

            Console.Write("You got an ");
            Console.WriteLine(lettergrade);

        }//End of Main
    }//End of Class
}//End of Namespace
