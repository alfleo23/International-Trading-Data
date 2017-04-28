using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlfonsoLeone15002679
{
     class BinarySearchTree<T> : BinaryTree<T> where T : IComparable
    {
        public BinarySearchTree()
        {
            root = null;
        }

        public void InsertItem(T item)
        {
            insertItem(item, ref root);
        }

        private void insertItem(T item, ref Node<T> tree)
        {
            if (tree == null)
                tree = new Node<T>(item);

            else if (item.CompareTo(tree.Data) < 0)
                insertItem(item, ref tree.Left);

            else if (item.CompareTo(tree.Data) > 0)
                insertItem(item, ref tree.Right);
        }

        public int Height()
        {
            return maxDepth(root);
        }

        public int maxDepth(Node<T> tree)
        {
            if (tree == null)
                return 0;
            else
            {
                int lDepth = maxDepth(tree.Left);
                int rDepth = maxDepth(tree.Right);


                if (lDepth > rDepth)
                    return (lDepth + 1);
                else
                    return (rDepth + 1);
            }
        }

        public int Count()
        {

            return count(root);
        }

        public int count(Node<T> tree)
        {
            int c = 1;

            if (tree == null)
                return 0;
            else
            {
                c += count(tree.Left);
                c += count(tree.Right);
                return c;

            }
        }

        public Boolean Contains(T item)
        {
            return contains(root, item);
        }

        public Boolean contains(Node<T> tree, T item)
        {
            if (tree == null)
            { return false; }
            else if (item.CompareTo(tree.Data) == 0)
            { return true; }
            else if (item.CompareTo(tree.Data) < 0)
            { return contains(tree.Left, item); }
            else
            { //item.CompareTo(tree.Data) > 0
                return contains(tree.Right, item);
            }
        }

        public void RemoveItem(T item)
        {
            removeItem(item, ref root);
        }

        public void removeItem(T item, ref Node<T> tree)
        {
            if (tree == null)
            { } // do nothing

            if (item.CompareTo(tree.Data) < 0)
                removeItem(item, ref tree.Left);
            if (item.CompareTo(tree.Data) > 0)
                removeItem(item, ref tree.Right);

            // found item
            if (item.CompareTo(tree.Data) == 0)
            {
                if (tree.Left == null && tree.Right == null)
                    tree = null;
                else if (tree.Left == null)
                    tree = tree.Right;
                else if (tree.Right == null)
                    tree = tree.Left;
                else
                {
                    T newRoot = leastItem(tree.Right);
                    tree.Data = newRoot;
                    removeItem(newRoot, ref tree.Right);
                }

            }

        }

        private T leastItem(Node<T> tree)
        {
            if (tree.Left == null)       //stopping condition
            {
                return tree.Data;
            }
            else
                return leastItem(tree.Left);

        }
    }
}
