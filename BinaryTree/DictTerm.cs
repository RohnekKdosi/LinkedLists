using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
    class DictTerm : IComparable
    {
        public DictTerm(string czech, string english)
        {
            Czech = czech;
            English = english;
        }

        public string Czech { get; set; }
        public string English { get; set; }

        public int CompareTo(object obj)
        {
            if (obj is DictTerm)
            {
                return Czech.CompareTo((obj as DictTerm).Czech);
            }
            throw new ArgumentException("Are you nuts? Comparing pears to apples? Learn programming and then fuck with my code, ok?");
        }
        public override string ToString()
        {
            return $"{Czech} = {English}";
        }
    }
}
