using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedLists
{
    class ListNode<T>
    {
        internal T value;
        internal ListNode<T> Next { get; set; }

        public ListNode(T value)
        {
            this.value = value;
        }
    }
}
