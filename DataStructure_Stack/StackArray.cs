using System;

namespace DataStructure_Stack
{
    public class StackArray<T> : IStack<T>
    {
        protected T[] array;
        protected int count;

        //PART 1 - QUESTION 4: Provide the time complexity for all asked members in the Stack<T> class.

        //*** Time complexity: O(1)
        public StackArray(int size)
        {
            array = new T[size];
            count = 0;
        }

        //*** Time complexity: O(n)
        public void Clear()
        {
            for (int i = 0; i < count; i++)
            {
                array[i] = default(T);
            }
            count = 0;
        }

        //*** Time complexity: O(n)
        public bool Contains(T item)
        {
            for (int i = 0; i < count; i++)
            {
                if (array[i].Equals(item))
                {
                    return true;
                }
            }
            return false;
        }

        //*** Time complexity: O(1)
        public int Count()
        {
            return count;
        }

        //*** Time complexity: O(n)
        public virtual void Push(T item)
        {
            if (count == array.Length)
                throw new IndexOutOfRangeException();
            array[count] = item;
            count++;
        }

        //*** Time complexity: O(n)
        public T Peek()
        {
            if (count == 0)
                throw new
                InvalidOperationException("Stack empty");

            int last_index = count - 1;
            return array[last_index];
        }

        //*** Time complexity: O(n)
        public T Pop()
        {
            if (count == 0)
                throw new
                InvalidOperationException("Stack empty");

            int last_index = count - 1;
            T item = array[last_index];
            array[last_index] = default(T);
            count--;
            return item;
        }
    }
}
