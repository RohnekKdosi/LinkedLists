using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedLists
{
    class MyLinkedList<T>
    {
        public ListNode<T> head;


        public void Add(T item)
        {
            ListNode<T> node = new ListNode<T>(item);
            if(head == null)
            {
                head = node;
            }
            else
            {
                ListNode<T> current = head;
                while(current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = node;
            }
        }
        public int Count { get { int counter = 0; ListNode<T> current = head; while(current!=null) { counter++; current = current.Next; } return counter; } }
        public void Clear ()
        {
            head = null;
        }
        public void AddToStart (T item)
        {
            ListNode<T> oldHead = head;
            head = new ListNode<T>(item);
            head.Next = oldHead;
        }
        public bool Contains (T item)
        {
            ListNode<T> current = head;
            while(current != null)
            {
                if (current.value.Equals(item))
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }
        public int IndexOf (T item)
        {
            ListNode<T> current = head;
            int index = 0;
            while(current != null)
            {
                if(current.value.Equals(item))
                {
                    return index;
                }
                index++;
                current = current.Next;
            }
            return -1;
        }
        public T GetItem (int index)
        {
            ListNode<T> current = head;
            if(index < 0)
            {
                throw new IndexOutOfRangeException("Don't put a negative index there, you moron!");
            }
            if (index > Count)
            {
                throw new IndexOutOfRangeException("The list doesn't have that many items, you idiot!");
            }
            while (Count != 0)
            {
                current = current.Next;
                index--;
            }
            return current.value;
        }
        public void Insert (int index, T item)
        {
            ListNode<T> current = head;
            if (index > Count)
            {
                throw new IndexOutOfRangeException("Learn to count, idiot! There's not that many elements!");
            }
            if (index < 0)
            {
                throw new IndexOutOfRangeException("There are no negative indexes here, do you lack a brain or do you just not use it?");
            }
            if (index == 0)
            {
                AddToStart(item);
                return;
            }
            while(index != 1)
            {
                current = current.Next;
                index--;
            }
            ListNode<T> old = current.Next;
            current.Next = new ListNode<T>(item)
            {
                Next = old
            };
        }
    }
}
