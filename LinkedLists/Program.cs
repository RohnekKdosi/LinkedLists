using System;

namespace LinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLinkedList<int> linkedList = new MyLinkedList<int>();
            linkedList.Add(1);
            linkedList.Add(2);
            linkedList.Add(3);
            linkedList.AddToStart(4);
            WriteList(linkedList);
            Console.WriteLine(linkedList.Count);
            Console.WriteLine(linkedList.Contains(4));
            Console.WriteLine(linkedList.Contains(5));
            Console.WriteLine(linkedList.IndexOf(2));
            Console.WriteLine(linkedList.IndexOf(5));
            Console.ReadKey();
        }

        static void WriteList(MyLinkedList<int> linkedList)
        {
            ListNode<int> current = linkedList.head;
            while(current!=null)
            {
                Console.WriteLine(current.value);
                current = current.Next;
            }
        }
    }
}
