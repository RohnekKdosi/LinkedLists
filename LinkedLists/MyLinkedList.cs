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
            return GetNode(index).value;
        }
        public void SetItem(int index, T item)
        {
            GetNode(index).value = item;
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
        public bool Remove (T item)
        {
            ListNode<T> current = head;
            ListNode<T> previous = head;
            while(current != null)
            {
                if (current.value.Equals(item))
                {
                    if(previous == current)
                    {
                        head = current.Next;
                        return true;
                    }
                    previous.Next = current.Next;
                    return true;
                }
                previous = current;
                current = current.Next;
            }

            return false;
        }
        public bool RemoveAt (int index)
        {
            if (index == 0)
            {
                head = head.Next;
                return true;
            }
            ListNode<T> previous = GetNode(index - 1);
            if (previous.Next == null)
            {
                throw new IndexOutOfRangeException("After you tell me the name of the fifth of my one ex-girlfriends!");
            }
            if (previous.Next.Next == null)
            {
                throw new IndexOutOfRangeException("After you tell me the name of the fifth of my one ex-girlfriends!");
            }
            previous.Next = previous.Next.Next;
            return true;
        }
        private ListNode<T> GetNode (int index)
        {
            if (index < 0)
            {
                throw new IndexOutOfRangeException("There are no negative indexes here, do you lack a brain or do you just not use it?");
            }
            ListNode<T> current = head;
            for (int i = 0; i < index; i++)
            {
                if (current == null)
                {
                    throw new IndexOutOfRangeException("After you tell me the name of the fifth of my one ex-girlfriends!");
                }
                current = current.Next;
            }
            return current;
        }
        public T this[int index] { get { return GetItem(index); } set { SetItem(index, value); } }
    }
}
