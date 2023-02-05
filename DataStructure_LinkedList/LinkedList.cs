using System;


namespace DataStructure_LinkedList
{
    public class LinkedList<T> : ILinkedList<T>
    {
        private GenericNode<T> head;
        private int count;

        public int Count { get => count; set => count = value; }
        public GenericNode<T> Head { get => head; set => head = value; }

        //*** TODO Time complexity: O(1)
        public LinkedList()
        {
            head = null;
            count = 0;
        }

        //*** TODO Time complexity: O(1)
        public void AddFirst(GenericNode<T> node)
        {
            node.Next = head;
            head = node;
            count++;
        }

        //*** TODO Time complexity: O(1)
        public GenericNode<T> AddFirst(T data)
        {
            GenericNode<T> node = new GenericNode<T>(data);
            AddFirst(node);
            return node;
        }

        //*** TODO Time complexity: O(n)
        public void AddLast(GenericNode<T> node)
        {
            if (head == null)
            {
                AddFirst(node);
                return;
            }
           
                GenericNode<T> current = head;
                while (current.Next != null)
              {
                   current = current.Next;
              }

          current.Next = node;
          count++;
        }

        //*** TODO Time complexity: O(n)
        public GenericNode<T> AddLast(T data)
        {
            GenericNode<T> node = new GenericNode<T>(data);
            AddLast(node);
            return node;
        }

        //*** TODO Time complexity: O(n)
        public void AddBefore(GenericNode<T> node, GenericNode<T> newNode)
        {
            //TODO PART 2 - QUESTION 1 - Implement here the AddBefore method:
            if (node == null)
            throw new ArgumentNullException("The node is null!!");
            
                else if (head == null)
                throw new InvalidOperationException("We cannot find the node because the current LinkedList is empty!!!");

            GenericNode<T> current = head;
            GenericNode<T> before = head;
            
                    while (current != node && current.Next != null)
                     {
                           before = current;
                           current = current.Next;
                     }

            if (current != node)
            throw new InvalidOperationException("The node is not found in the LinkedList!!!");
           
            newNode.Next = current;
            before.Next = newNode;
            count++;
    }

    //*** TODO Time complexity: O(n) 
    public GenericNode<T> AddBefore(GenericNode<T> node, T data)
        {
            GenericNode<T> newNode = new GenericNode<T>(data);
            AddBefore(node, newNode);
            return newNode;
        }

        //*** TODO Time complexity: O(n)
        public void AddSorted(GenericNode<T> newNode)
        {
            //TODO PART 2 - QUESTION 2 - Implement here the AddSorted method
            GenericNode<T> current = head;
            GenericNode<T> before = head;

                 while (current.Next != null && current < newNode)
                 {
                    before = current;
                    current = current.Next;
                 }
           
            newNode.Next = current;
            before.Next = newNode;
            count++;
        }

        //*** TODO Time complexity: O(n)
        public GenericNode<T> AddSorted(T data)
        {
            GenericNode<T> newNode = new GenericNode<T>(data);
            AddSorted(newNode);
            return newNode;
        }

        //*** TODO Time complexity: O(n)
        public GenericNode<T> RemoveByIndex(int index)
        {
            //TODO PART 2 - QUESTION 3: Remove the following line and
            //implement the RemoveByIndex method here:
            GenericNode<T> deleted = head;
            GenericNode<T> before = head;

            if (index == 0)
            {
              head = deleted.Next;
              count--;
              return deleted;
            }

           
                   for (int i = 0; deleted != null && i < index; i++)
                 {
                    before = deleted;
                    deleted = deleted.Next;
                 }

            
            if (deleted.Next == null)
            {
              before.Next = null;
            }
            
                    else
                    {
                       before.Next = deleted.Next;
                    }
            
            
            count--;
            return deleted;
    }
        
        //*** TODO Time complexity: O(n)
        public GenericNode<T> RemoveByValue(T data)
        {
            //TODO PART 2 - QUESTION 4 - Fix the RemoveByValue method to be able to remove the head.

            GenericNode<T> current = head;
            GenericNode<T> before = null;
            
            
            while (current != null)
            {
               if (current.Data.Equals(data))
                {
                    // If we try to remove the head then the previous
                    // node will be null and will cause an exception
                   if (before != null)
                {
                    before.Next = current.Next;
                }
                    
                    
                          else
                        {
                           head = current.Next;
                        }

                    count--;
                    return current;
                 }
                

                before = current;
                current = current.Next;
            }


            return null;
        }

        //*** TODO Time complexity: O(n)
        public override string ToString()
        {
            var stringbuild = new System.Text.StringBuilder();
            var current = head;
           
                 while (current != null)
                  {
                         if (stringbuild.Length > 0)
           
              stringbuild.Append(", ");
              stringbuild.Append(current.Data);
              current = current.Next;
            }


            return stringbuild.ToString();
        }

    }
}
