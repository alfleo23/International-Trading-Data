using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlfonsoLeone15002679
{
     class AVLTree<T> : BinarySearchTree<T> where T : IComparable
    {
        public void InsertItemAVL(T item)
        {
            insertItemAVL(item, ref root);
        }

        private void insertItemAVL(T item, ref Node<T> tree)
        {
            if (tree == null)
                tree = new Node<T>(item);
            else if (item.CompareTo(tree.Data) < 0)
                insertItemAVL(item, ref tree.Left);
            else if (item.CompareTo(tree.Data) > 0)
                insertItemAVL(item, ref tree.Right);

            tree.BalanceFactor = maxDepth(tree.Left) - maxDepth(tree.Right);

            if (tree.BalanceFactor <= -2)
                rotateLeft(ref tree);
           else if (tree.BalanceFactor >= 2)
                rotateRight(ref tree);

        }

        private void rotateLeft(ref Node<T> tree)
        {
            if (tree.Right.BalanceFactor > 0)  // double rotate
                rotateRight(ref tree.Right);

           
                Node<T> oldRoot = tree;
                Node<T> newRoot = tree.Right;

                oldRoot.Right = newRoot.Left;
                newRoot.Left = oldRoot;

                tree = newRoot;
            
        }

        private void rotateRight(ref Node<T> tree)
        {
            if (tree.Left.BalanceFactor < 0)
                rotateLeft(ref tree.Left);

            
                Node<T> oldRoot = tree;
                Node<T> newRoot = tree.Left;

                oldRoot.Left = newRoot.Right;
                newRoot.Right = oldRoot;

                tree = newRoot;
            
        }

        public void RemoveItemAVL(T item)
        {
            removeItemAVL(item, ref root);
        }

        public Node<T> removeItemAVL(T item, ref Node<T> tree)
        {
            removeItem(item, ref tree);
            if (tree == null)
            {
                return tree;
            }
            int balance  = maxDepth(tree.Left) - maxDepth(tree.Right);

            // Left Left Case
            if (balance > 1 && (maxDepth(tree.Left.Left) - maxDepth(tree.Left.Right) >= 0) )
            {
                rotateRight(ref tree);
            }

            // Left Right Case
            if (balance > 1 && (maxDepth(tree.Left.Left) - maxDepth(tree.Left.Right) >= 0))
            {
                rotateLeft(ref tree.Left);
                rotateRight(ref tree); 
            }

            // Right Right Case
            if (balance < -1 && (maxDepth(tree.Right.Left) - maxDepth(tree.Right.Right) <= 0) )
            {
                rotateLeft(ref tree);
            }

            // Right Left Case
            if (balance < -1 && (maxDepth(tree.Right.Left) - maxDepth(tree.Right.Right) <= 0))
            {
                rotateRight(ref tree.Right);
                rotateLeft(ref tree);
            }

            return tree;
        }

    } // end of class
}
