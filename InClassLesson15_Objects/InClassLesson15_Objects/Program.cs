using System;

namespace InClassLesson15_Objects
{
    //create a class with two variables
    class Person
    {
        public string name;
        int age;
        public int[] x;

        public void birthday()
        {
            age++;
        }

        void whatever()
        {
            //does something to x
            x[0]++;
        }

        public int GetAge()
        {
            return age;
        }

        public bool SetAge(int ValidAge)
        {
            whatever();
            if (ValidAge > 0)
            {
                age = ValidAge;
                return true;
            }
            else
                return false;
        }

        public void Test()
        {
            Program p;
        }

        public static void thisiStatic()
        {
            Console.WriteLine("Whatup");
        }
    }

    //add public to one variable to access the variable

    //add a method to the class (birthday)

    //explain how varaibles can be used in methods scope

    //create getter for age

    //explain private vs public


    class Program
    {
        static void Main(string[] args)
        {
            //create the object of the class. with name and age
            Person uncle;


            //explain why we need to use new. show memory on big board
            uncle = new Person();

            //set a name value using '.'
            uncle.name = "Louie";

            //get a value, run f10. Show what memory looks like
            //show how age is private.

            //add array to class. Explain how memory is being pointed

            //set array
            uncle.x = new int[5];

            //change index 0 of the array using the class
            uncle.x[0] = 4;

            //change index 1 of a local array pointing to the same spot
            int[] myArray;

            myArray = uncle.x;

           

            myArray[1] = 9;

            //set one object equal to another
            Person marshy;

            marshy = uncle;

            marshy.name = "Marshy";

            //show in f10 how the & of one is actually storing a pointer value.

            //create a new spot in memory for marshy(new object). What will happen to the array inside?
            marshy = new Person();

            uncle.name = "Louie";
            marshy.name = "Marshy";

            //set new object's array equal to old objects array
            marshy.x = uncle.x;

            //change index 2 of the new spot. Do they all change? Or just one?
            marshy.x[2] = 10;

            marshy.birthday();
            marshy.birthday();
            marshy.birthday();
            marshy.birthday();
            marshy.birthday();

            Console.WriteLine(marshy.GetAge());

            bool result = marshy.SetAge(10);

            if(marshy.SetAge(-5))
            {
                //whatever
            }
            else
            {
                //get new age
            }

            //Explain static vs non-static (show how no object is needed for static)
            Person.thisiStatic();
            
        }
    }
}
