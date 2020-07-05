using System;
using System.Collections.Generic;
using System.Text;

namespace marshcode
{
    //Class Mstask can store other objects
    class mstack<T>
    {
        T Data;

        mstack<T> Next;

        mstack<T> Temp;

        bool IsNotEmpty = false;

        public mstack<T> cur;

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

        public IEnumerator<T> GetEnumerator()
        {
            cur = Temp;

            while (cur != null)
            {
                yield return cur.Data;
                cur = cur.Next;

            }

        }

    }//End of mstack class



    

}
