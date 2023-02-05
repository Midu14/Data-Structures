using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure_Stack
{
    // class StackDynamicArray<T> that is inherited from Stack<T>:
    internal class StackDynamicArray<T> : StackArray<T>
    {
        //Base Constructor StackArray and passing the value 2:
        public StackDynamicArray() : base(2) {}

        //Push method: and the Time complexity: 0(n): 
        public override void Push(T item)
        {
           if (array.Length == count)
            {
                //Double the size of the array: 
                T[] tempArray = new T[array.Length * 2];
                for (int x = 0; x < array.Length; x++) 
                {
                    tempArray[x] = array[x];
                }

                array = tempArray;
            }
            //time complexity for all asked members in the Stack<T> class:
            array[count] = item;
            count++;
        }
    }
}
