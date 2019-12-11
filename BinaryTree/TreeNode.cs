using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
    class TreeNode<T> where T: IComparable
    {
        internal T value;

        public TreeNode(T value)
        {
            this.value = value;
        }

        internal TreeNode<T> Left;
        internal TreeNode<T> Right;

    }
}
