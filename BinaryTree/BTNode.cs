using System;
namespace BinaryTree
{
    public class BTNode
    {
        public int Value;
        public BTNode Left;
        public BTNode Right;
        public BTNode(int val)
        {
            Value = val;
            Left = null;
            Right = null;
        }
    }
}