using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
    class BinaryTree<T> where T: IComparable
    {
        protected TreeNode<T> _root = null;

        public void Add (T item)
        {
            Add(item, ref _root);
        }
        protected void Add(T item, ref TreeNode<T> node)
        {
            if(node==null)
            {
                node = new TreeNode<T>(item);
            }
            else if(item.CompareTo(node.value) == -1)
            {
                Add(item, ref node.Left);
            }
            else
            {
                Add(item, ref node.Right);
            }
        }

        public override string ToString()
        {
            return base.ToString();
        }
        protected string TreeToString(TreeNode<T> node)
        {
            if (node == null) return "";
            return $"{TreeToString(node.Left)} / {node.value} / {TreeToString(node.Right)}";
        }

        public TreeNode<T> Find(T item)
        {
            return Find(item, _root);
        }
        protected TreeNode<T> Find (T item, TreeNode<T> node)
        {
            if(node != null)
            {
                switch (item.CompareTo(node.value))
                {
                    case 0:
                    {
                        return node;
                    }
                    case -1:
                    {
                        return Find(item, node.Left);
                    }
                    case 1:
                    {
                        return Find(item, node.Right);
                    }
                }
            }
            return null;
        }
    }
}
