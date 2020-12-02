using System;

namespace BinaryTree
{
    public class Program
    {
        static void Main(string[] args)
        {
            BTree bt = new BTree();
            bt.Add(5);
            // 5r
            bt.Add(4);
            // 5r 
          // 4
            bt.Add(6);
            //  5
            //4   6
            bt.Add(7);
            //   5
            // 4    6
            //        7
            bt.Add(8);
            //    5
            // 4     6
            //          7
            //             8
            bt.Preorder(bt.Root);
            bt.InOrder(bt.Root);
            bt.PostOrder(bt.Root);

        }
    }
}
