using System;
namespace BinaryTree
{
    public class BTree
    {
        public BTNode Root;
        public BTree()
        {
            Root = null;
        }
        public void Add(int val)
        {
            BTNode newNode = new BTNode(val);
            if(Root == null)
            {
                Root = newNode;
            }
            else
            {
                BTNode runner = Root;
                bool placed = false;
                while(!placed)
                {
                    if(newNode.Value > runner.Value)
                    {
                        if(runner.Right == null)
                        {
                            runner.Right = newNode;
                            return;
                        }
                        else
                        {
                            runner = runner.Right;
                        }
                    }
                    else
                    {
                        if(runner.Left == null)
                        {
                            runner.Left = newNode;
                            return;
                        }
                        else
                        {
                            runner = runner.Left;
                        }
                    }
                }
            }
        }
        public void Preorder(BTNode root)
        {
            if(root == null)
            {
                return;
            }
            System.Console.WriteLine(root.Value);
            Preorder(root.Left);
            Preorder(root.Right);
        }
        public void InOrder(BTNode root)
        {
            if(root == null){return;}
            InOrder(root.Left);
            System.Console.WriteLine(root.Value);
            InOrder(root.Right);
        }
        public void PostOrder(BTNode root)
        {
            if(root == null){return;}
            Preorder(root.Left);
            Preorder(root.Right);
            System.Console.WriteLine(root.Value);
        }
    }
}