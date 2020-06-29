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
            //Creates new stack piece if it is empty
            if (Next == null)
            {
                Next = new mstack();
            }

            //Assigns the data if this stack is full
            if (Data != 0)
            {
                Next.Push(Data);
                Data = NewStack;
            }
            else
            {
                Data = NewStack;
            }
        }

        //Pop takes the top of the mstack and returns it
        public int Pop()
        {
            //Int for placeholding data
            int PlaceHolder = Data;

            //Grabs the data from the next one in the stack if it is not empty
            if (Next != null)
            {
                Data = Next.Pop();
            }

            //Return the PlaceHolder
            return PlaceHolder;
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            mstack stack = new mstack();

            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());


        }
    }
}
