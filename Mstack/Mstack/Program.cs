using System;

namespace Mstack
{
    //Class Mstask can store other objects
    class mstack
    {
        //Created two variables, Data and Next
        //Data holds an int variable
        public int Data;

        //Data is the next one in the mstack
        public mstack Next;

        //Push Adds one mstack to the mstack
        public void Push(int NewStack)
        {
            //Creates new stack piece
            Next = new mstack();

            //Assigns the data
            Next.Data = NewStack;
        }

        //Pop takes the top of the stask and returns
        public int Pop()
        {
            //Returns the next mstack's data
            if (Next.Data != 0)
            {
                return Next.Data;
            }
            else
            {
                Next.Next = new mstack();
                return Next.Next.Data;
            }
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            mstack stack = new mstack();
            stack.Push(10);
            Console.WriteLine( stack.Pop());
        }
    }
}
