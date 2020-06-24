using System;

namespace InClassLesson16_MoreObjects
{
    class Animal
    {
        protected string type;

        //run

        //eat

        //do animal stuff

        
    }


    //create a class
    class Person:Animal
    {
        public string name;
        private int age;

    //pass the contructor a varible
        public Person(string StartName, int StartAge)
        {
            name = StartName;
            age = StartAge;
        }
        //create a constructor
        public Person()
        {
        }

        public Person(string StartType)
        {
            type = StartType;
        }

        static public bool operator > (Person p1, Person p2)
        {
            return p1.age > p2.age;
        }
        static public bool operator <(Person p1, Person p2)
        {
            return p1.age < p2.age;
        }

        static public Person operator ++(Person p1)
        {
            p1.age++;

            return p1;
        }

        static public void test()
        {
            Console.WriteLine("test");
        }

    }


    //explain that there is a destructor, but it runs automatticly


    //show inherietence. Use animal class

    //explain protected vs private


    class Program
    {
        static void Main(string[] args)
        {
            //show how a contructor will set name
            Person uncle = new Person("Uncel", 40);

            uncle.name = "louie";

            Person marshy;

            marshy = new Person("marshy", 36);

            //show how adding a parent will add attributes
           // uncle.type = "dog";

            Animal mika = new Animal();

            // mika.type = "cat";

            //change the public attribute in the parent class to private. Show errors

            //Change it to protected. show erros

            if(uncle > marshy)
            {
             Console.WriteLine("Uncle is older");
            }

            marshy++;

            Person.test();

            marshy = uncle;

            if(uncle == marshy)
            {
                Console.WriteLine("Same");
            }
       
        }
    }
}
