using System;
using System.Collections.Generic;
using System.Text;
using Tree;

namespace ConsoleApp1
{
    class BinarySearchTree
    {
        public Node Root;

        public void Insert(int data)
        {
            Root = InsertRec(Root, data);
        }

        private Node InsertRec(Node root, int data)
        {
            if (root == null)
                return new Node(data);

            if (data < root.Data)
                root.Left = InsertRec(root.Left, data);
            else if (data > root.Data)
                root.Right = InsertRec(root.Right, data);

            return root;
        }