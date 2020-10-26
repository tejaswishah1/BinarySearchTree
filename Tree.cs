using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    class Tree<T> where T : IComparable<T>
    {
        public T NodeData { get; set; }
        public Tree<T> LeftTree { get; set; }
        public Tree<T> RightTree { get; set; }
        public Tree(T nodeData)
        {
            this.NodeData = nodeData;
            this.LeftTree = null;
            this.RightTree = null;
        }
        int leftCount = 0;
        int rightCount = 0;
        bool result = false;

        public void Insert(T item)
        {
            T currentNodeValue = this.NodeData;
            if ((currentNodeValue.CompareTo(item)) > 0)
            {
                if (this.LeftTree == null)
                    this.LeftTree = new Tree<T>(item);
                else
                    this.LeftTree.Insert(item);


            }
            else if (this.RightTree == null)
                this.RightTree = new Tree<T>(item);
            else
                this.RightTree.Insert(item);

        }
        public void Display()
        {
            if (this.LeftTree != null)
            {
                this.leftCount++;
                this.LeftTree.Display();

            }
            Console.WriteLine(this.NodeData.ToString());
            if (this.RightTree != null)
            {
                this.rightCount++;
                this.RightTree.Display();

            }

        }
        public void GetSize()
        {
            Console.WriteLine("Size " + this.leftCount + " " +this.rightCount );

        }
        public bool ifExists(T element, Tree<T> node)
        {
            if (node == null)
            {
                return false;
            }
            if (node.NodeData.Equals(element))
            {
                Console.WriteLine("Found data in Tree: " + node.NodeData);
                result = true;
            }
            else
            {
                Console.WriteLine("Current element {0} is not in tree", node.NodeData );

            }
            if (element.CompareTo(node.NodeData) < 0)
            {
                ifExists(element, node.LeftTree);
            }
            if (element.CompareTo(node.NodeData) > 0)
            {
                ifExists(element, node.RightTree);
            }
            return result;
        }
    }


    }

