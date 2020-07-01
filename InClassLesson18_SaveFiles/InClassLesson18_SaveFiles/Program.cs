using System;
using System.Text;

namespace InClassLesson18_SaveFiles
{
    class Program
    {
         //define where we are going to save it.
        static string path = @"C:\Users\User\Documents\GitHub\NoPressure\InClassLesson18_SaveFiles\test.txt";

        static void Save()
        {
            //define our message that will be saved
            string message = "Hello Marshy!!!\n";


            //save into a file
            System.IO.File.WriteAllText(path, message);

        }


        static string Load()
        {

            return System.IO.File.ReadAllText(path);
        }

        static void Main(string[] args)
        {
            Save();
            //Console.WriteLine(Load());


            //define our message that will be saved
            string message = "\nHello again Marshy!!!\n" ;

            string[] msg = { "dog", "cat" };




            //save into a file
            System.IO.File.WriteAllLines(path, msg);

            Console.WriteLine( System.IO.File.ReadAllLines(path));
            //System.IO.File.AppendAllText(path, message);
            //System.IO.File.AppendAllText(path, message);



            //System.IO.File.WriteAllText(path, "using enconding");
        }
    }
}
