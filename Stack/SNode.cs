using System;
namespace Stack
{
    public class SNode
    {
        public int Value;
        public SNode Next;
        public SNode(int val)
        {
            Value = val;
            Next = null;
        }
    }
}