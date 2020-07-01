using System;
using masrshy;

namespace Mstack
{

    class mstack<T>
    {
        T Data;

        mstack<T> Next;

        mstack<T> Temp;

        bool IsNotEmpty = false;

        public T Pop() 
        {
            //If the stack isnt empty
            if (IsNotEmpty)
            {

                //Create a placeholder for the data
                T PlaceHolder = Temp.Data;

                //Remove it from the stack
                Temp = Temp.Next;

                //if it is empty, IsEmpty = false
                if (Temp == null) 
                {
                    IsNotEmpty = false;
                }

                return PlaceHolder;
            }
            else 
            {
                return Data;
            }
        }

        public void Push(T NewStack) 
        {
            //If is empty
            if (!IsNotEmpty)
            {
                //First time HasPushed
                IsNotEmpty = true;

                //Create temp
                Temp = new mstack<T>();

                //Assign NewStack to temp
                Temp.Data = NewStack;
            }
            else
            {
                //Assign Next
                Next = new mstack<T>();

                //Make Next point to temp
                Next.Next = Temp;

                //Make temp point to next
                Temp = Next;

                //Asign Temp.Data to NewStack
                Temp.Data = NewStack;

                //Make next not point to next
                Next = null;

            }

        }
    }


    //Class Mstask can store other objects
    class mstack2
    {
        //Created two variables, Data and Next
        //Data holds an int variable
        public int Data;

        //Next is the next one in the mstack
        public mstack2 Next;

        //Push Adds one mstack to the mstack
        public void Push(int NewStack)
        {
            //Creates new stack piece if it is empty
            if (Next == null)
            {
                Next = new mstack2();
            }

            //Assigns the data if this stack is full
            if (Data != 0)
            {
                Next.Push(Data);
            }

            Data = NewStack;

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


            mstack<Mstring> ms2 = new mstack<Mstring>();

            Mstring one = new Mstring("louie");
            Mstring two = new Mstring("marshy");

            ms2.Push(one);
            ms2.Push(two);






            mstack2 stack = new mstack2();

            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());


            for(int i =0; i< 10000; i++)
            {
                stack.Push(i);
            }

            Console.WriteLine("*********************NOW POP IT*********************");
            Console.WriteLine("*********************NOW POP IT*********************");
            Console.WriteLine("*********************NOW POP IT*********************");
            Console.WriteLine("*********************NOW POP IT*********************");
            Console.WriteLine("*********************NOW POP IT*********************");
            Console.WriteLine("*********************NOW POP IT*********************");
            Console.WriteLine("*********************NOW POP IT*********************");
            Console.WriteLine("*********************NOW POP IT*********************");

            int j =0;
            while(stack.Pop()!=0)
            { 
            }

            Console.ReadKey();


            mstack<int> ms = new mstack<int>();

            for (int i = 0; i < 10000; i++)
            {
                ms.Push(i);
            }

            Console.WriteLine("*********************NOW POP IT*********************");
            Console.WriteLine("*********************NOW POP IT*********************");
            Console.WriteLine("*********************NOW POP IT*********************");
            Console.WriteLine("*********************NOW POP IT*********************");
            Console.WriteLine("*********************NOW POP IT*********************");
            Console.WriteLine("*********************NOW POP IT*********************");
            Console.WriteLine("*********************NOW POP IT*********************");
            Console.WriteLine("*********************NOW POP IT*********************");

            j = 0;
            while (ms.Pop() != 0)
            {
            }

        }
    }
}
